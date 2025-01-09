Shader "Jauved/Effect/Add_AddWaves_Water_Masked" {
Properties {
	_MainTex ("Main Texture", 2D) = "white" {}
	_MainColor ("Color", Color) = (0.5,0.5,0.5,0.5)
	_MainTexScroll_U ("Main_U Speed", Float) = 0.0
	_MainTexScroll_V ("Main_V Speed", Float) = 0.0
	_MainTurbTex ("Main Turb Map", 2D) = "white" {}
	_MainTurbTexValue ("Main Turb Map Value", Range(-1,1)) = 0.0
	_MainTurbTexScroll_U ("Main Turb_U Speed", Float) = 0.0
	_MainTurbTexScroll_V ("Main Turb_V Speed", Float) = 0.0
	_MaskTex ("Mask(Gray)", 2D) = "white" {}
}

Category {
	Tags { "Queue"="Transparent" "IgnoreProjector"="True" "RenderType"="Transparent" "PreviewType"="Plane" }
	ColorMask RGB
	Cull Off Lighting Off ZWrite Off

	SubShader {
		Pass {
			
			Blend SrcAlpha One
		
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			#pragma target 2.0
			#pragma multi_compile_particles
			#pragma multi_compile_fog
			
			#include "UnityCG.cginc"

			sampler2D _MainTex;
			fixed4 _MainColor;
			sampler2D _MainTurbTex;
			fixed _MainTurbTexValue;
			float _MainTexScroll_U;
			float _MainTexScroll_V;
			float _MainTurbTexScroll_U;
			float _MainTurbTexScroll_V;
			sampler2D _MaskTex;
			
			struct appdata_t {
				float4 vertex : POSITION;
				fixed4 color : COLOR;
				float2 texcoord : TEXCOORD0;
				float2 texcoordturb : TEXCOORD1;
				float2 texcoordmask : TEXCOORD2;
			};

			struct v2f {
				float4 vertex : SV_POSITION;
				fixed4 color : COLOR;
				float2 texcoord : TEXCOORD0;
				float2 texcoordturb : TEXCOORD1;
				float2 texcoordmask : TEXCOORD2;
				UNITY_FOG_COORDS(3)
			};
			
			float4 _MainTex_ST;
			float4 _MainTurbTex_ST;
			float4 _MaskTex_ST;

			v2f vert (appdata_t v)
			{
				v2f o;
				o.vertex = UnityObjectToClipPos(v.vertex);
				o.color = v.color;
				o.texcoord = TRANSFORM_TEX(v.texcoord,_MainTex) + frac(float2(_MainTexScroll_U, _MainTexScroll_V) * _Time.y);
				o.texcoordturb = TRANSFORM_TEX(v.texcoordturb, _MainTurbTex) + frac(float2(_MainTurbTexScroll_U, _MainTurbTexScroll_V) * _Time.y);
				o.texcoordmask = v.texcoordmask;
				UNITY_TRANSFER_FOG(o,o.vertex);
				return o;
			}

			sampler2D_float _CameraDepthTexture;
			float _InvFade;
			
			fixed4 frag (v2f i) : SV_Target
			{				
				i.texcoord += tex2D(_MainTurbTex, i.texcoordturb).rg * _MainTurbTexValue * tex2D(_MaskTex, i.texcoordmask).r ;
				fixed4 col = 2.0f * i.color * _MainColor * tex2D(_MainTex, i.texcoord) * tex2D(_MaskTex, i.texcoordmask).r;
				UNITY_APPLY_FOG(i.fogCoord, col);
				return col;
			}
			ENDCG 
		}
	}	
}
}
