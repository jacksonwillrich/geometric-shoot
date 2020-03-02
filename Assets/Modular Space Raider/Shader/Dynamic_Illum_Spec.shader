Shader "MHShaders/Dynamic_Illum_Specular" 
{
Properties {	
	_SpecColor ("Specular Color", Color) = (0.5, 0.5, 0.5, 1)
	_SpecularStrenght ("Specular Strength", Range (0.01, 1)) = 0.078125
	_SourceColor ("Source channel", Vector) = (1, 0, 0, 1)
	_OldColorMargin ("Source Color Margin", Float) = 0.8
	_TargetColor ("New Color", Color) = (1, 0, 0, 1)	
	_MainTex ("Base (RGB) Gloss (A)", 2D) = "white" {}
	_Illum ("Illumin (RGB)", 2D) = "black" {}	
	_Shininess ("Illumination Strength", Range (0.01, 1)) = 0.078125
}
SubShader {
	Tags { "RenderType"="Opaque" }
	LOD 300
		
CGPROGRAM
#pragma surface surf BlinnPhong
#pragma target 3.0

sampler2D _MainTex;
sampler2D _Illum;
fixed4 _Color;
half _SpecularStrenght;
half _Shininess;
half _OldColorMargin;

fixed4 _SourceColor;
fixed4 _TargetColor;

struct Input {
	float2 uv_MainTex;
	float2 uv_Illum;
};

void surf (Input IN, inout SurfaceOutput o) {
	fixed4 diffuse = tex2D(_MainTex, IN.uv_MainTex);
	fixed3 tex = diffuse.rgb;
	fixed3 sourceColorDirection = _SourceColor.rgb;
	fixed3 colorDirection = tex * sourceColorDirection;
		
	float intensity = length(colorDirection);
	float texIntensity = length( tex );
	float result = texIntensity * _OldColorMargin - intensity;	

	float oldShare =  max ( 0, normalize(result));		
	float newShare = 1 - oldShare;

	//old color existance
	fixed3 originalColor = oldShare * tex;
	
	float3 white = 1;						
	float colorProportion = length (tex - colorDirection);	
	fixed3 newColor = lerp(_TargetColor * intensity, white, colorProportion);	
	newColor = newColor * newShare;
	
	o.Albedo = originalColor + newColor;
	o.Emission = tex2D(_Illum, IN.uv_Illum).rgb * _Shininess;
	o.Gloss = diffuse.a;	
	o.Specular = _SpecularStrenght;
}
ENDCG
}
FallBack "Self-Illumin/Diffuse"
}
