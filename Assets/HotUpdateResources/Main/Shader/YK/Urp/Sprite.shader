Shader "YK/URP/SpriteShader"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
        _Color("add color", Color) = (1,1,1,1)
        _BeAttack("BeAttack",Int) = 0
    }
    SubShader
    {
        Tags {"RenderType" = "Transparent" "RenderPipeline" = "UniversalPipeline"}
        ZWrite Off
        Blend SrcAlpha OneMinusSrcAlpha
        LOD 100
        Cull Off

        Pass
        {
            HLSLPROGRAM
            #pragma vertex vert
            #pragma fragment frag

            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"

            struct appdata
            {
                float4 vertex:POSITION;
                float2 texcoord:TEXCOORD0;
                half4 color : COLOR;
            };

            struct v2f
            {
                float4 pos:SV_POSITION;
                float2 uv:TEXCOORD0;
                half4 color : COLOR;
            };

			CBUFFER_START(UnityPerMaterial)
            sampler2D _MainTex;
            float4 _MainTex_ST;
            half4 _Color;
            int _BeAttack;//对外参数表示是否被攻击了
			CBUFFER_END
			
            v2f vert (appdata v)
            {
                v2f o;
                o.pos = TransformObjectToHClip(v.vertex);
                o.uv = TRANSFORM_TEX(v.texcoord, _MainTex);
                o.color = v.color;
                return o;
            }

            half4 frag (v2f i) : SV_TARGET
            {
                half4 tex = tex2D(_MainTex, i.uv);
                if (_BeAttack == 1) {//是否被攻击
                    if (tex.rgba.a == 1)
                    {
                        tex.rgb = tex.rgb + _Color.rgb;
                    }
                }
                return tex;
            }
            ENDHLSL
        }
    }
}