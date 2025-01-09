// Shader created with Shader Forge v1.38 
// Shader Forge (c) Freya Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:2,bsrc:0,bdst:0,dpts:2,wrdp:False,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:9361,x:33379,y:32718,varname:node_9361,prsc:2|emission-9230-OUT;n:type:ShaderForge.SFN_Color,id:2804,x:32720,y:32690,ptovrint:False,ptlb:color,ptin:_color,varname:node_2804,prsc:2,glob:False,taghide:False,taghdr:True,tagprd:False,tagnsco:False,tagnrm:False,c1:0.5,c2:0.5,c3:0.5,c4:1;n:type:ShaderForge.SFN_Tex2d,id:689,x:32876,y:32429,ptovrint:False,ptlb:texture,ptin:_texture,varname:node_689,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:37ca488e93ff9aa4f996cd4968fbda9e,ntxv:0,isnm:False|UVIN-6530-OUT;n:type:ShaderForge.SFN_Multiply,id:9230,x:33126,y:32760,varname:node_9230,prsc:2|A-689-RGB,B-2804-RGB,C-4737-RGB,D-8954-RGB,E-8954-A;n:type:ShaderForge.SFN_Tex2d,id:4737,x:32701,y:33022,ptovrint:False,ptlb:mask,ptin:_mask,varname:node_4737,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False;n:type:ShaderForge.SFN_VertexColor,id:8954,x:32863,y:32994,varname:node_8954,prsc:2;n:type:ShaderForge.SFN_ValueProperty,id:3307,x:31544,y:32424,ptovrint:False,ptlb:u,ptin:_u,varname:node_3307,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Time,id:8357,x:31666,y:32602,varname:node_8357,prsc:2;n:type:ShaderForge.SFN_Multiply,id:6388,x:31894,y:32437,varname:node_6388,prsc:2|A-8357-T,B-3307-OUT;n:type:ShaderForge.SFN_Append,id:5435,x:32043,y:32616,varname:node_5435,prsc:2|A-6388-OUT,B-9880-OUT;n:type:ShaderForge.SFN_ValueProperty,id:681,x:31666,y:32875,ptovrint:False,ptlb:v,ptin:_v,varname:node_681,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Multiply,id:9880,x:31824,y:32811,varname:node_9880,prsc:2|A-8357-T,B-681-OUT;n:type:ShaderForge.SFN_TexCoord,id:4064,x:32007,y:32890,varname:node_4064,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Add,id:5436,x:32260,y:32616,varname:node_5436,prsc:2|A-5435-OUT,B-4064-UVOUT;n:type:ShaderForge.SFN_ValueProperty,id:7658,x:31714,y:31880,ptovrint:False,ptlb:u_noise,ptin:_u_noise,varname:_u_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_Time,id:9863,x:31631,y:31965,varname:node_9863,prsc:2;n:type:ShaderForge.SFN_Multiply,id:185,x:31985,y:31880,varname:node_185,prsc:2|A-9863-T,B-7658-OUT;n:type:ShaderForge.SFN_Append,id:6677,x:32084,y:32088,varname:node_6677,prsc:2|A-185-OUT,B-942-OUT;n:type:ShaderForge.SFN_ValueProperty,id:37,x:31713,y:32263,ptovrint:False,ptlb:v_noise,ptin:_v_noise,varname:_v_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_Multiply,id:942,x:31902,y:32176,varname:node_942,prsc:2|A-9863-T,B-37-OUT;n:type:ShaderForge.SFN_TexCoord,id:8804,x:32117,y:32204,varname:node_8804,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Add,id:3351,x:32318,y:32103,varname:node_3351,prsc:2|A-6677-OUT,B-8804-UVOUT;n:type:ShaderForge.SFN_Add,id:6530,x:32672,y:32469,varname:node_6530,prsc:2|A-5436-OUT,B-9628-OUT;n:type:ShaderForge.SFN_Tex2d,id:3545,x:32469,y:32764,ptovrint:False,ptlb:noise_tex,ptin:_noise_tex,varname:node_3545,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False|UVIN-3351-OUT;n:type:ShaderForge.SFN_Multiply,id:9628,x:32451,y:32949,varname:node_9628,prsc:2|A-3545-R,B-9679-OUT;n:type:ShaderForge.SFN_ValueProperty,id:9679,x:32177,y:33249,ptovrint:False,ptlb:rongdong,ptin:_rongdong,varname:node_9679,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;proporder:2804-689-4737-3307-681-7658-37-3545-9679;pass:END;sub:END;*/

Shader "Shader Forge/add_uv_move" {
    Properties {
        [HDR]_color ("color", Color) = (0.5,0.5,0.5,1)
        _texture ("texture", 2D) = "white" {}
        _mask ("mask", 2D) = "white" {}
        _u ("u", Float ) = 1
        _v ("v", Float ) = 1
        _u_noise ("u_noise", Float ) = 0
        _v_noise ("v_noise", Float ) = 0
        _noise_tex ("noise_tex", 2D) = "white" {}
        _rongdong ("rongdong", Float ) = 0
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            Blend One One
            Cull Off
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase
            #pragma only_renderers d3d9 d3d11 glcore gles gles3 metal 
            #pragma target 3.0
            uniform float4 _color;
            uniform sampler2D _texture; uniform float4 _texture_ST;
            uniform sampler2D _mask; uniform float4 _mask_ST;
            uniform float _u;
            uniform float _v;
            uniform float _u_noise;
            uniform float _v_noise;
            uniform sampler2D _noise_tex; uniform float4 _noise_tex_ST;
            uniform float _rongdong;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
                float4 vertexColor : COLOR;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 vertexColor : COLOR;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.vertexColor = v.vertexColor;
                o.pos = UnityObjectToClipPos( v.vertex );
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : COLOR {
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
////// Lighting:
////// Emissive:
                float4 node_8357 = _Time;
                float4 node_9863 = _Time;
                float2 node_3351 = (float2((node_9863.g*_u_noise),(node_9863.g*_v_noise))+i.uv0);
                float4 _noise_tex_var = tex2D(_noise_tex,TRANSFORM_TEX(node_3351, _noise_tex));
                float2 node_6530 = ((float2((node_8357.g*_u),(node_8357.g*_v))+i.uv0)+(_noise_tex_var.r*_rongdong));
                float4 _texture_var = tex2D(_texture,TRANSFORM_TEX(node_6530, _texture));
                float4 _mask_var = tex2D(_mask,TRANSFORM_TEX(i.uv0, _mask));
                float3 emissive = (_texture_var.rgb*_color.rgb*_mask_var.rgb*i.vertexColor.rgb*i.vertexColor.a);
                float3 finalColor = emissive;
                return fixed4(finalColor,1);
            }
            ENDCG
        }
        Pass {
            Name "ShadowCaster"
            Tags {
                "LightMode"="ShadowCaster"
            }
            Offset 1, 1
            Cull Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma only_renderers d3d9 d3d11 glcore gles gles3 metal 
            #pragma target 3.0
            struct VertexInput {
                float4 vertex : POSITION;
            };
            struct VertexOutput {
                V2F_SHADOW_CASTER;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.pos = UnityObjectToClipPos( v.vertex );
                TRANSFER_SHADOW_CASTER(o)
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : COLOR {
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
                SHADOW_CASTER_FRAGMENT(i)
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
