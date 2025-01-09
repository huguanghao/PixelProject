// Made with Amplify Shader Editor
// Available at the Unity Asset Store - http://u3d.as/y3X 
Shader "Hotwater/2022/Urp_All_1230"
{
	Properties
	{
		[HideInInspector] _EmissionColor("Emission Color", Color) = (1,1,1,1)
		[HideInInspector] _AlphaCutoff("Alpha Cutoff ", Range(0, 1)) = 0.5
		[ASEBegin][Enum(blend,10,add,1)]_Float1("材质模式", Float) = 10
		[Enum(UnityEngine.Rendering.CullMode)]_Float2("双面模式", Float) = 0
		[Toggle]_Float4("深度写入", Float) = 0
		[Enum(UnityEngine.Rendering.CompareFunction)]_Ztestmode("深度测试", Float) = 4
		[Enum(UnityEngine.Rendering.ColorWriteMask)]_Float60("colormask", Float) = 15
		[Enum(UnityEngine.Rendering.CompareFunction)]_Ztestmode1("stencil_comp", Float) = 0
		[Enum(UnityEngine.Rendering.StencilOp)]_Ztestmode2("stencil_pass", Float) = 0
		_Float46("stencil_reference", Float) = 0
		[Header(___________________________________________________________________________________________________________________________________________________________________________________________________________________________________________)][Header(Depthfade)]_Float16("软粒子（羽化边缘）", Float) = 0
		[Toggle]_Float5("反向软粒子(强化边缘）", Float) = 0
		_Float28("边缘强度", Float) = 1
		_Float30("边缘收窄", Float) = 1
		[Header(___________________________________________________________________________________________________________________________________________________________________________________________________________________________________________)][Header(Fresnel)][KeywordEnum(Off,On)] _Keyword5("菲尼尔开关", Float) = 0
		_power3("菲尼尔强度", Float) = 1
		_Float19("菲尼尔范围", Float) = 1
		[Toggle]_Float20("反向菲尼尔（虚化边缘）", Float) = 0
		[HDR][Header(___________________________________________________________________________________________________________________________________________________________________________________________________________________________________________)][Header(color)]_Color0("颜色", Color) = (1,1,1,1)
		_Float14("整体颜色强度", Float) = 1
		[Toggle]_Float35("启用第二面颜色", Float) = 0
		[HDR]_Color3("颜色2", Color) = (1,1,1,1)
		[KeywordEnum(Off,On)] _Keyword7("AlphaClamp", Float) = 0
		_Float15("alpha强度", Range( 0 , 10)) = 1
		[NoScaleOffset][Header(___________________________________________________________________________________________________________________________________________________________________________________________________________________________________________)][Header(Main)]_maintex("主贴图", 2D) = "white" {}
		[KeywordEnum(A,R)] _Keyword0("主贴图通道", Float) = 0
		[KeywordEnum(Repeat,Clamp)] _Keyword8("主贴图UV", Float) = 0
		_Float39("主贴图旋转", Range( -1 , 1)) = 0
		[Toggle]_Float50("主贴图极坐标开关", Float) = 0
		_Float34("主贴图细节对比度", Float) = 1
		_Float37("主贴图细节提亮", Float) = 1
		_Float36("细节平滑过渡", Range( 0 , 1)) = 1
		_Vector8("主贴图tilling&offset", Vector) = (1,1,0,0)
		_Vector0("主贴图流动速度", Vector) = (0,0,0,0)
		[NoScaleOffset][Header(Ramptex)]_Gradienttex("混合颜色贴图", 2D) = "white" {}
		[KeywordEnum(RGB,R)] _Keyword1("混合颜色贴图通道", Float) = 0
		[HDR]blendcolor("混合图颜色", Color) = (0,0,0,0)
		[KeywordEnum(Repeat,Clamp)] _Keyword9("ramptexUV", Float) = 0
		_Float40("颜色混合贴图旋转", Range( -1 , 1)) = 0
		[Toggle]_Float61("ramptex极坐标开关", Float) = 0
		_Vector9("颜色混合图tilling&offset", Vector) = (1,1,0,0)
		_Vector7("颜色图流动速度", Vector) = (0,0,0,0)
		[KeywordEnum(Lerp,Multiply)] _Keyword3("颜色混合模式", Float) = 0
		_Float29("颜色混合（lerp模式下使用）", Range( 0 , 1)) = 0
		[NoScaleOffset][Header(___________________________________________________________________________________________________________________________________________________________________________________________________________________________________________)][Header(Mask)]_Mask("遮罩01", 2D) = "white" {}
		[KeywordEnum(A,R)] _Keyword4("mask01通道", Float) = 0
		[KeywordEnum(Repeat,Clamp)] _Keyword10("Mask01UV", Float) = 0
		_Float43("遮罩01旋转", Range( -1 , 1)) = 0
		[Toggle]_Float51("Mask01极坐标开关", Float) = 0
		_Vector10("Mask01_tilling&offset", Vector) = (1,1,0,0)
		_Vector11("Mask01流动速度", Vector) = (0,0,0,0)
		[NoScaleOffset]_Mask1("遮罩02", 2D) = "white" {}
		[KeywordEnum(A,R)] _Keyword6("mask02通道", Float) = 0
		[KeywordEnum(Repeat,Clamp)] _Keyword11("Mask02UV", Float) = 0
		_Float42("遮罩02旋转", Range( -1 , 1)) = 0
		[Toggle]_Float52("Mask02极坐标开关", Float) = 0
		_Vector12("Mask02_tilling&offset", Vector) = (1,1,0,0)
		_Vector13("Mask02流动速度", Vector) = (0,0,0,0)
		[NoScaleOffset][Header(___________________________________________________________________________________________________________________________________________________________________________________________________________________________________________)][Header(Dissolove)]_dissolvetex("溶解贴图", 2D) = "white" {}
		[KeywordEnum(Repeat,Clamp)] _Keyword12("溶解UV", Float) = 0
		_Float41("溶解贴图旋转", Range( -1 , 1)) = 0
		[NoScaleOffset]_TextureSample0("溶解方向贴图（渐变）", 2D) = "white" {}
		_Float47("溶解方向旋转", Range( -1 , 1)) = 0
		[Toggle]_Float53("溶解极坐标开关", Float) = 0
		_Vector14("溶解_tilling&offset", Vector) = (1,1,0,0)
		_Vector15("溶解流动速度", Vector) = (0,0,0,0)
		_Float6("溶解", Range( 0 , 1)) = 0
		_Float8("软硬", Range( 0.5 , 1)) = 0.5
		[Toggle]_Float25("开启亮边溶解", Float) = 0
		_Float17("亮边宽度", Range( 0 , 0.2)) = 0
		[HDR]_Color1("亮边颜色", Color) = (1,1,1,1)
		[NoScaleOffset][Header(___________________________________________________________________________________________________________________________________________________________________________________________________________________________________________)][Header(Noise)]_noise("扰动贴图", 2D) = "white" {}
		[KeywordEnum(Repeat,Clamp)] _Keyword14("扰动UV", Float) = 0
		_Float44("扰动贴图旋转", Range( -1 , 1)) = 0
		[NoScaleOffset]_TextureSample1("扰动遮罩", 2D) = "white" {}
		_Float57("扰动遮罩旋转", Range( -1 , 1)) = 0
		[Toggle]_Float54("扰动极坐标开关", Float) = 0
		_Vector16("扰动_tilling&offset", Vector) = (1,1,0,0)
		_Vector17("扰动流动速度", Vector) = (0,0,0,0)
		[KeywordEnum(off,on)] doublenoise("双重扰动", Float) = 0
		_Float9("主贴图扰动强度", Float) = 0
		_Float18("mask扰动强度", Float) = 0
		_Float33("溶解扰动强度", Float) = 0
		[Space(20)]_flowmaptex("flowmaptex", 2D) = "white" {}
		_Float32("flowmap扰动", Range( 0 , 1)) = 0
		[NoScaleOffset][Header(___________________________________________________________________________________________________________________________________________________________________________________________________________________________________________)][Header(Vertex)]_vertextex("顶点偏移贴图", 2D) = "white" {}
		[KeywordEnum(Repeat,Clamp)] _Keyword13("顶点偏移UV", Float) = 0
		_Float45("顶点贴图旋转", Range( -1 , 1)) = 0
		[Toggle]_Float56("顶点偏移极坐标开关", Float) = 0
		_Vector18("顶点偏移_tilling&offset", Vector) = (1,1,0,0)
		_Vector19("顶点偏移流动速度", Vector) = (0,0,0,0)
		[NoScaleOffset]_vertextex1("顶点遮罩", 2D) = "white" {}
		[KeywordEnum(Repeat,Clamp)] _Keyword16("顶点偏移遮罩UV", Float) = 0
		_Float48("顶点遮罩旋转", Range( -1 , 1)) = 0
		[Toggle]_Float62("顶点遮罩极坐标开关", Float) = 0
		_Vector22("顶点遮罩_tilling&offset", Vector) = (1,1,0,0)
		_Vector23("顶点遮罩流动速度", Vector) = (0,0,0,0)
		_Vector5("顶点偏移强度", Vector) = (0,0,0,0)
		[Toggle][Header(___________________________________________________________________________________________________________________________________________________________________________________________________________________________________________)][Header(Custom)]_Float10("custom1xy控制主贴图偏移", Float) = 0
		[Toggle]_Float12("custom1zw控制mask01偏移", Float) = 0
		[Toggle]_Float11("custom2x控制溶解", Float) = 0
		[Toggle]_Float31("custom2y控制flowmap扭曲", Float) = 0
		[Toggle]_Float24("custom2z控制折射（热扭曲）", Float) = 0
		[ASEEnd][Toggle]_Float22("custom2w控制顶点偏移强度", Float) = 0
		[HideInInspector] _texcoord( "", 2D ) = "white" {}

		//_TessPhongStrength( "Tess Phong Strength", Range( 0, 1 ) ) = 0.5
		//_TessValue( "Tess Max Tessellation", Range( 1, 32 ) ) = 16
		//_TessMin( "Tess Min Distance", Float ) = 10
		//_TessMax( "Tess Max Distance", Float ) = 25
		//_TessEdgeLength ( "Tess Edge length", Range( 2, 50 ) ) = 16
		//_TessMaxDisp( "Tess Max Displacement", Float ) = 25
	}

	SubShader
	{
		LOD 0

		
		Tags { "RenderPipeline"="UniversalPipeline" "RenderType"="Transparent" "Queue"="Transparent" }
		
		Cull [_Float2]
		AlphaToMask Off
		
		HLSLINCLUDE
		#pragma target 2.0

		#pragma prefer_hlslcc gles
		#pragma exclude_renderers d3d11_9x 

		#ifndef ASE_TESS_FUNCS
		#define ASE_TESS_FUNCS
		float4 FixedTess( float tessValue )
		{
			return tessValue;
		}
		
		float CalcDistanceTessFactor (float4 vertex, float minDist, float maxDist, float tess, float4x4 o2w, float3 cameraPos )
		{
			float3 wpos = mul(o2w,vertex).xyz;
			float dist = distance (wpos, cameraPos);
			float f = clamp(1.0 - (dist - minDist) / (maxDist - minDist), 0.01, 1.0) * tess;
			return f;
		}

		float4 CalcTriEdgeTessFactors (float3 triVertexFactors)
		{
			float4 tess;
			tess.x = 0.5 * (triVertexFactors.y + triVertexFactors.z);
			tess.y = 0.5 * (triVertexFactors.x + triVertexFactors.z);
			tess.z = 0.5 * (triVertexFactors.x + triVertexFactors.y);
			tess.w = (triVertexFactors.x + triVertexFactors.y + triVertexFactors.z) / 3.0f;
			return tess;
		}

		float CalcEdgeTessFactor (float3 wpos0, float3 wpos1, float edgeLen, float3 cameraPos, float4 scParams )
		{
			float dist = distance (0.5 * (wpos0+wpos1), cameraPos);
			float len = distance(wpos0, wpos1);
			float f = max(len * scParams.y / (edgeLen * dist), 1.0);
			return f;
		}

		float DistanceFromPlane (float3 pos, float4 plane)
		{
			float d = dot (float4(pos,1.0f), plane);
			return d;
		}

		bool WorldViewFrustumCull (float3 wpos0, float3 wpos1, float3 wpos2, float cullEps, float4 planes[6] )
		{
			float4 planeTest;
			planeTest.x = (( DistanceFromPlane(wpos0, planes[0]) > -cullEps) ? 1.0f : 0.0f ) +
						  (( DistanceFromPlane(wpos1, planes[0]) > -cullEps) ? 1.0f : 0.0f ) +
						  (( DistanceFromPlane(wpos2, planes[0]) > -cullEps) ? 1.0f : 0.0f );
			planeTest.y = (( DistanceFromPlane(wpos0, planes[1]) > -cullEps) ? 1.0f : 0.0f ) +
						  (( DistanceFromPlane(wpos1, planes[1]) > -cullEps) ? 1.0f : 0.0f ) +
						  (( DistanceFromPlane(wpos2, planes[1]) > -cullEps) ? 1.0f : 0.0f );
			planeTest.z = (( DistanceFromPlane(wpos0, planes[2]) > -cullEps) ? 1.0f : 0.0f ) +
						  (( DistanceFromPlane(wpos1, planes[2]) > -cullEps) ? 1.0f : 0.0f ) +
						  (( DistanceFromPlane(wpos2, planes[2]) > -cullEps) ? 1.0f : 0.0f );
			planeTest.w = (( DistanceFromPlane(wpos0, planes[3]) > -cullEps) ? 1.0f : 0.0f ) +
						  (( DistanceFromPlane(wpos1, planes[3]) > -cullEps) ? 1.0f : 0.0f ) +
						  (( DistanceFromPlane(wpos2, planes[3]) > -cullEps) ? 1.0f : 0.0f );
			return !all (planeTest);
		}

		float4 DistanceBasedTess( float4 v0, float4 v1, float4 v2, float tess, float minDist, float maxDist, float4x4 o2w, float3 cameraPos )
		{
			float3 f;
			f.x = CalcDistanceTessFactor (v0,minDist,maxDist,tess,o2w,cameraPos);
			f.y = CalcDistanceTessFactor (v1,minDist,maxDist,tess,o2w,cameraPos);
			f.z = CalcDistanceTessFactor (v2,minDist,maxDist,tess,o2w,cameraPos);

			return CalcTriEdgeTessFactors (f);
		}

		float4 EdgeLengthBasedTess( float4 v0, float4 v1, float4 v2, float edgeLength, float4x4 o2w, float3 cameraPos, float4 scParams )
		{
			float3 pos0 = mul(o2w,v0).xyz;
			float3 pos1 = mul(o2w,v1).xyz;
			float3 pos2 = mul(o2w,v2).xyz;
			float4 tess;
			tess.x = CalcEdgeTessFactor (pos1, pos2, edgeLength, cameraPos, scParams);
			tess.y = CalcEdgeTessFactor (pos2, pos0, edgeLength, cameraPos, scParams);
			tess.z = CalcEdgeTessFactor (pos0, pos1, edgeLength, cameraPos, scParams);
			tess.w = (tess.x + tess.y + tess.z) / 3.0f;
			return tess;
		}

		float4 EdgeLengthBasedTessCull( float4 v0, float4 v1, float4 v2, float edgeLength, float maxDisplacement, float4x4 o2w, float3 cameraPos, float4 scParams, float4 planes[6] )
		{
			float3 pos0 = mul(o2w,v0).xyz;
			float3 pos1 = mul(o2w,v1).xyz;
			float3 pos2 = mul(o2w,v2).xyz;
			float4 tess;

			if (WorldViewFrustumCull(pos0, pos1, pos2, maxDisplacement, planes))
			{
				tess = 0.0f;
			}
			else
			{
				tess.x = CalcEdgeTessFactor (pos1, pos2, edgeLength, cameraPos, scParams);
				tess.y = CalcEdgeTessFactor (pos2, pos0, edgeLength, cameraPos, scParams);
				tess.z = CalcEdgeTessFactor (pos0, pos1, edgeLength, cameraPos, scParams);
				tess.w = (tess.x + tess.y + tess.z) / 3.0f;
			}
			return tess;
		}
		#endif //ASE_TESS_FUNCS

		ENDHLSL

		
		Pass
		{
			
			Name "Forward"
			Tags { "LightMode"="UniversalForward" }
			
			Blend SrcAlpha [_Float1], One OneMinusSrcAlpha
			ZWrite [_Float4]
			ZTest [_Ztestmode]
			Offset 0 , 0
			ColorMask [_Float60]
			Stencil
			{
				Ref [_Float46]
				Comp [_Ztestmode1]
				Pass [_Ztestmode2]
				Fail Keep
				ZFail Keep
			}

			HLSLPROGRAM
			
			#define _RECEIVE_SHADOWS_OFF 1
			#define ASE_SRP_VERSION 100801
			#define REQUIRE_DEPTH_TEXTURE 1

			
			#pragma vertex vert
			#pragma fragment frag

			#include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
			#include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Lighting.hlsl"
			#include "Packages/com.unity.render-pipelines.core/ShaderLibrary/Color.hlsl"
			#include "Packages/com.unity.render-pipelines.core/ShaderLibrary/UnityInstancing.hlsl"
			#include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/ShaderGraphFunctions.hlsl"

			#if ASE_SRP_VERSION <= 70108
			#define REQUIRES_VERTEX_SHADOW_COORD_INTERPOLATOR
			#endif

			#define ASE_NEEDS_VERT_NORMAL
			#define ASE_NEEDS_VERT_POSITION
			#define ASE_NEEDS_FRAG_WORLD_POSITION
			#define ASE_NEEDS_FRAG_COLOR
			#pragma shader_feature_local _KEYWORD13_REPEAT _KEYWORD13_CLAMP
			#pragma shader_feature_local _KEYWORD16_REPEAT _KEYWORD16_CLAMP
			#pragma shader_feature_local _KEYWORD3_LERP _KEYWORD3_MULTIPLY
			#pragma shader_feature_local _KEYWORD8_REPEAT _KEYWORD8_CLAMP
			#pragma shader_feature_local DOUBLENOISE_OFF DOUBLENOISE_ON
			#pragma shader_feature_local _KEYWORD14_REPEAT _KEYWORD14_CLAMP
			#pragma shader_feature_local _KEYWORD1_RGB _KEYWORD1_R
			#pragma shader_feature_local _KEYWORD9_REPEAT _KEYWORD9_CLAMP
			#pragma shader_feature_local _KEYWORD5_OFF _KEYWORD5_ON
			#pragma shader_feature_local _KEYWORD0_A _KEYWORD0_R
			#pragma shader_feature_local _KEYWORD10_REPEAT _KEYWORD10_CLAMP
			#pragma shader_feature_local _KEYWORD12_REPEAT _KEYWORD12_CLAMP
			#pragma shader_feature_local _KEYWORD7_OFF _KEYWORD7_ON
			#pragma shader_feature_local _KEYWORD4_A _KEYWORD4_R
			#pragma shader_feature_local _KEYWORD6_A _KEYWORD6_R
			#pragma shader_feature_local _KEYWORD11_REPEAT _KEYWORD11_CLAMP


			struct VertexInput
			{
				float4 vertex : POSITION;
				float3 ase_normal : NORMAL;
				float4 ase_texcoord : TEXCOORD0;
				float4 ase_texcoord2 : TEXCOORD2;
				float4 ase_texcoord1 : TEXCOORD1;
				float4 ase_color : COLOR;
				UNITY_VERTEX_INPUT_INSTANCE_ID
			};

			struct VertexOutput
			{
				float4 clipPos : SV_POSITION;
				#if defined(ASE_NEEDS_FRAG_WORLD_POSITION)
				float3 worldPos : TEXCOORD0;
				#endif
				#if defined(REQUIRES_VERTEX_SHADOW_COORD_INTERPOLATOR) && defined(ASE_NEEDS_FRAG_SHADOWCOORDS)
				float4 shadowCoord : TEXCOORD1;
				#endif
				#ifdef ASE_FOG
				float fogFactor : TEXCOORD2;
				#endif
				float4 ase_texcoord3 : TEXCOORD3;
				float4 ase_texcoord4 : TEXCOORD4;
				float4 ase_texcoord5 : TEXCOORD5;
				float4 ase_texcoord6 : TEXCOORD6;
				float4 ase_color : COLOR;
				float4 ase_texcoord7 : TEXCOORD7;
				UNITY_VERTEX_INPUT_INSTANCE_ID
				UNITY_VERTEX_OUTPUT_STEREO
			};

			CBUFFER_START(UnityPerMaterial)
			float4 _Gradienttex_ST;
			float4 _Color3;
			float4 _Vector8;
			float4 _Color1;
			float4 _TextureSample1_ST;
			float4 _Vector17;
			float4 _noise_ST;
			float4 _Vector16;
			float4 _Vector10;
			float4 _flowmaptex_ST;
			float4 _Mask_ST;
			float4 _Vector11;
			float4 _Vector7;
			float4 _Vector9;
			float4 blendcolor;
			float4 _Color0;
			float4 _Vector0;
			float4 _TextureSample0_ST;
			float4 _maintex_ST;
			float4 _Vector19;
			float4 _Vector12;
			float4 _Vector22;
			float4 _Mask1_ST;
			float4 _Vector23;
			float4 _dissolvetex_ST;
			float4 _Vector14;
			float4 _Vector15;
			float4 _vertextex_ST;
			float4 _Vector13;
			float4 _Vector18;
			float3 _Vector5;
			float _Float15;
			float _Float20;
			float _Float34;
			float _Float36;
			float _Float19;
			float _Float37;
			float _Float25;
			float _Float47;
			float _Float17;
			float _Float41;
			float _Float12;
			float _Float51;
			float _Float18;
			float _Float33;
			float _Float43;
			float _Float6;
			float _Float11;
			float _Float53;
			float _Float8;
			float _power3;
			float _Float2;
			float _Float35;
			float _Ztestmode1;
			float _Float60;
			float _Float1;
			float _Ztestmode;
			float _Ztestmode2;
			float _Float46;
			float _Float4;
			float _Float24;
			float _Float56;
			float _Float45;
			float _Float22;
			float _Float62;
			float _Float48;
			float _Float28;
			float _Float14;
			float _Float16;
			float _Float30;
			float _Float10;
			float _Float50;
			float _Float54;
			float _Float57;
			float _Float44;
			float _Float9;
			float _Float32;
			float _Float31;
			float _Float39;
			float _Float52;
			float _Float61;
			float _Float40;
			float _Float29;
			float _Float5;
			float _Float42;
			#ifdef TESSELLATION_ON
				float _TessPhongStrength;
				float _TessValue;
				float _TessMin;
				float _TessMax;
				float _TessEdgeLength;
				float _TessMaxDisp;
			#endif
			CBUFFER_END
			sampler2D _vertextex;
			sampler2D _vertextex1;
			uniform float4 _CameraDepthTexture_TexelSize;
			sampler2D _maintex;
			sampler1D _TextureSample1;
			sampler2D _noise;
			sampler2D _flowmaptex;
			sampler2D _Gradienttex;
			sampler2D _Mask;
			sampler2D _TextureSample0;
			sampler2D _dissolvetex;
			sampler2D _Mask1;


						
			VertexOutput VertexFunction ( VertexInput v  )
			{
				VertexOutput o = (VertexOutput)0;
				UNITY_SETUP_INSTANCE_ID(v);
				UNITY_TRANSFER_INSTANCE_ID(v, o);
				UNITY_INITIALIZE_VERTEX_OUTPUT_STEREO(o);

				float2 appendResult557 = (float2(_Vector19.x , _Vector19.y));
				float2 uv_vertextex = v.ase_texcoord.xy * _vertextex_ST.xy + _vertextex_ST.zw;
				float2 appendResult550 = (float2(( _Vector18.x - 1.0 ) , ( _Vector18.y - 1.0 )));
				float2 appendResult546 = (float2(_Vector18.z , _Vector18.w));
				float2 CenteredUV15_g44 = ( uv_vertextex - float2( 0.5,0.5 ) );
				float2 break17_g44 = CenteredUV15_g44;
				float2 appendResult23_g44 = (float2(( length( CenteredUV15_g44 ) * _Vector18.x * 2.0 ) , ( atan2( break17_g44.x , break17_g44.y ) * ( 1.0 / TWO_PI ) * _Vector18.y )));
				float2 lerpResult556 = lerp( (uv_vertextex*appendResult550 + ( uv_vertextex + appendResult546 )) , (appendResult23_g44*float2( 1,1 ) + appendResult546) , _Float56);
				float2 panner168 = ( 1.0 * _Time.y * appendResult557 + lerpResult556);
				float cos398 = cos( ( _Float45 * PI ) );
				float sin398 = sin( ( _Float45 * PI ) );
				float2 rotator398 = mul( panner168 - float2( 0.5,0.5 ) , float2x2( cos398 , -sin398 , sin398 , cos398 )) + float2( 0.5,0.5 );
				float2 break658 = rotator398;
				float clampResult659 = clamp( break658.x , 0.0 , 1.0 );
				float clampResult660 = clamp( break658.y , 0.0 , 1.0 );
				float2 appendResult661 = (float2(clampResult659 , clampResult660));
				#if defined(_KEYWORD13_REPEAT)
				float2 staticSwitch662 = rotator398;
				#elif defined(_KEYWORD13_CLAMP)
				float2 staticSwitch662 = appendResult661;
				#else
				float2 staticSwitch662 = rotator398;
				#endif
				float4 texCoord167 = v.ase_texcoord2;
				texCoord167.xy = v.ase_texcoord2.xy * float2( 1,1 ) + float2( 0,0 );
				float lerpResult176 = lerp( 1.0 , texCoord167.w , _Float22);
				float2 appendResult698 = (float2(_Vector23.x , _Vector23.y));
				float2 appendResult691 = (float2(( _Vector22.x - 1.0 ) , ( _Vector22.y - 1.0 )));
				float2 appendResult686 = (float2(_Vector22.z , _Vector22.w));
				float2 CenteredUV15_g45 = ( uv_vertextex - float2( 0.5,0.5 ) );
				float2 break17_g45 = CenteredUV15_g45;
				float2 appendResult23_g45 = (float2(( length( CenteredUV15_g45 ) * _Vector22.x * 2.0 ) , ( atan2( break17_g45.x , break17_g45.y ) * ( 1.0 / TWO_PI ) * _Vector22.y )));
				float2 lerpResult697 = lerp( (uv_vertextex*appendResult691 + ( uv_vertextex + appendResult686 )) , (appendResult23_g45*float2( 1,1 ) + appendResult686) , _Float62);
				float2 panner700 = ( 1.0 * _Time.y * appendResult698 + lerpResult697);
				float cos701 = cos( ( _Float48 * PI ) );
				float sin701 = sin( ( _Float48 * PI ) );
				float2 rotator701 = mul( panner700 - float2( 0.5,0.5 ) , float2x2( cos701 , -sin701 , sin701 , cos701 )) + float2( 0.5,0.5 );
				float2 break702 = rotator701;
				float clampResult704 = clamp( break702.x , 0.0 , 1.0 );
				float clampResult703 = clamp( break702.y , 0.0 , 1.0 );
				float2 appendResult705 = (float2(clampResult704 , clampResult703));
				#if defined(_KEYWORD16_REPEAT)
				float2 staticSwitch706 = rotator701;
				#elif defined(_KEYWORD16_CLAMP)
				float2 staticSwitch706 = appendResult705;
				#else
				float2 staticSwitch706 = rotator701;
				#endif
				float3 vertexoffset181 = ( tex2Dlod( _vertextex, float4( staticSwitch662, 0, 0.0) ).r * v.ase_normal * _Vector5 * lerpResult176 * tex2Dlod( _vertextex1, float4( staticSwitch706, 0, 0.0) ).r );
				
				float3 vertexPos97 = v.vertex.xyz;
				float4 ase_clipPos97 = TransformObjectToHClip((vertexPos97).xyz);
				float4 screenPos97 = ComputeScreenPos(ase_clipPos97);
				o.ase_texcoord3 = screenPos97;
				float3 ase_worldNormal = TransformObjectToWorldNormal(v.ase_normal);
				o.ase_texcoord7.xyz = ase_worldNormal;
				
				o.ase_texcoord4.xy = v.ase_texcoord.xy;
				o.ase_texcoord5 = v.ase_texcoord1;
				o.ase_texcoord6 = v.ase_texcoord2;
				o.ase_color = v.ase_color;
				
				//setting value to unused interpolator channels and avoid initialization warnings
				o.ase_texcoord4.zw = 0;
				o.ase_texcoord7.w = 0;
				#ifdef ASE_ABSOLUTE_VERTEX_POS
					float3 defaultVertexValue = v.vertex.xyz;
				#else
					float3 defaultVertexValue = float3(0, 0, 0);
				#endif
				float3 vertexValue = vertexoffset181;
				#ifdef ASE_ABSOLUTE_VERTEX_POS
					v.vertex.xyz = vertexValue;
				#else
					v.vertex.xyz += vertexValue;
				#endif
				v.ase_normal = v.ase_normal;

				float3 positionWS = TransformObjectToWorld( v.vertex.xyz );
				float4 positionCS = TransformWorldToHClip( positionWS );

				#if defined(ASE_NEEDS_FRAG_WORLD_POSITION)
				o.worldPos = positionWS;
				#endif
				#if defined(REQUIRES_VERTEX_SHADOW_COORD_INTERPOLATOR) && defined(ASE_NEEDS_FRAG_SHADOWCOORDS)
				VertexPositionInputs vertexInput = (VertexPositionInputs)0;
				vertexInput.positionWS = positionWS;
				vertexInput.positionCS = positionCS;
				o.shadowCoord = GetShadowCoord( vertexInput );
				#endif
				#ifdef ASE_FOG
				o.fogFactor = ComputeFogFactor( positionCS.z );
				#endif
				o.clipPos = positionCS;
				return o;
			}

			#if defined(TESSELLATION_ON)
			struct VertexControl
			{
				float4 vertex : INTERNALTESSPOS;
				float3 ase_normal : NORMAL;
				float4 ase_texcoord : TEXCOORD0;
				float4 ase_texcoord2 : TEXCOORD2;
				float4 ase_texcoord1 : TEXCOORD1;
				float4 ase_color : COLOR;

				UNITY_VERTEX_INPUT_INSTANCE_ID
			};

			struct TessellationFactors
			{
				float edge[3] : SV_TessFactor;
				float inside : SV_InsideTessFactor;
			};

			VertexControl vert ( VertexInput v )
			{
				VertexControl o;
				UNITY_SETUP_INSTANCE_ID(v);
				UNITY_TRANSFER_INSTANCE_ID(v, o);
				o.vertex = v.vertex;
				o.ase_normal = v.ase_normal;
				o.ase_texcoord = v.ase_texcoord;
				o.ase_texcoord2 = v.ase_texcoord2;
				o.ase_texcoord1 = v.ase_texcoord1;
				o.ase_color = v.ase_color;
				return o;
			}

			TessellationFactors TessellationFunction (InputPatch<VertexControl,3> v)
			{
				TessellationFactors o;
				float4 tf = 1;
				float tessValue = _TessValue; float tessMin = _TessMin; float tessMax = _TessMax;
				float edgeLength = _TessEdgeLength; float tessMaxDisp = _TessMaxDisp;
				#if defined(ASE_FIXED_TESSELLATION)
				tf = FixedTess( tessValue );
				#elif defined(ASE_DISTANCE_TESSELLATION)
				tf = DistanceBasedTess(v[0].vertex, v[1].vertex, v[2].vertex, tessValue, tessMin, tessMax, GetObjectToWorldMatrix(), _WorldSpaceCameraPos );
				#elif defined(ASE_LENGTH_TESSELLATION)
				tf = EdgeLengthBasedTess(v[0].vertex, v[1].vertex, v[2].vertex, edgeLength, GetObjectToWorldMatrix(), _WorldSpaceCameraPos, _ScreenParams );
				#elif defined(ASE_LENGTH_CULL_TESSELLATION)
				tf = EdgeLengthBasedTessCull(v[0].vertex, v[1].vertex, v[2].vertex, edgeLength, tessMaxDisp, GetObjectToWorldMatrix(), _WorldSpaceCameraPos, _ScreenParams, unity_CameraWorldClipPlanes );
				#endif
				o.edge[0] = tf.x; o.edge[1] = tf.y; o.edge[2] = tf.z; o.inside = tf.w;
				return o;
			}

			[domain("tri")]
			[partitioning("fractional_odd")]
			[outputtopology("triangle_cw")]
			[patchconstantfunc("TessellationFunction")]
			[outputcontrolpoints(3)]
			VertexControl HullFunction(InputPatch<VertexControl, 3> patch, uint id : SV_OutputControlPointID)
			{
			   return patch[id];
			}

			[domain("tri")]
			VertexOutput DomainFunction(TessellationFactors factors, OutputPatch<VertexControl, 3> patch, float3 bary : SV_DomainLocation)
			{
				VertexInput o = (VertexInput) 0;
				o.vertex = patch[0].vertex * bary.x + patch[1].vertex * bary.y + patch[2].vertex * bary.z;
				o.ase_normal = patch[0].ase_normal * bary.x + patch[1].ase_normal * bary.y + patch[2].ase_normal * bary.z;
				o.ase_texcoord = patch[0].ase_texcoord * bary.x + patch[1].ase_texcoord * bary.y + patch[2].ase_texcoord * bary.z;
				o.ase_texcoord2 = patch[0].ase_texcoord2 * bary.x + patch[1].ase_texcoord2 * bary.y + patch[2].ase_texcoord2 * bary.z;
				o.ase_texcoord1 = patch[0].ase_texcoord1 * bary.x + patch[1].ase_texcoord1 * bary.y + patch[2].ase_texcoord1 * bary.z;
				o.ase_color = patch[0].ase_color * bary.x + patch[1].ase_color * bary.y + patch[2].ase_color * bary.z;
				#if defined(ASE_PHONG_TESSELLATION)
				float3 pp[3];
				for (int i = 0; i < 3; ++i)
					pp[i] = o.vertex.xyz - patch[i].ase_normal * (dot(o.vertex.xyz, patch[i].ase_normal) - dot(patch[i].vertex.xyz, patch[i].ase_normal));
				float phongStrength = _TessPhongStrength;
				o.vertex.xyz = phongStrength * (pp[0]*bary.x + pp[1]*bary.y + pp[2]*bary.z) + (1.0f-phongStrength) * o.vertex.xyz;
				#endif
				UNITY_TRANSFER_INSTANCE_ID(patch[0], o);
				return VertexFunction(o);
			}
			#else
			VertexOutput vert ( VertexInput v )
			{
				return VertexFunction( v );
			}
			#endif

			half4 frag ( VertexOutput IN , FRONT_FACE_TYPE ase_vface : FRONT_FACE_SEMANTIC ) : SV_Target
			{
				UNITY_SETUP_INSTANCE_ID( IN );
				UNITY_SETUP_STEREO_EYE_INDEX_POST_VERTEX( IN );

				#if defined(ASE_NEEDS_FRAG_WORLD_POSITION)
				float3 WorldPosition = IN.worldPos;
				#endif
				float4 ShadowCoords = float4( 0, 0, 0, 0 );

				#if defined(ASE_NEEDS_FRAG_SHADOWCOORDS)
					#if defined(REQUIRES_VERTEX_SHADOW_COORD_INTERPOLATOR)
						ShadowCoords = IN.shadowCoord;
					#elif defined(MAIN_LIGHT_CALCULATE_SHADOWS)
						ShadowCoords = TransformWorldToShadowCoord( WorldPosition );
					#endif
				#endif
				float4 screenPos97 = IN.ase_texcoord3;
				float4 ase_screenPosNorm97 = screenPos97 / screenPos97.w;
				ase_screenPosNorm97.z = ( UNITY_NEAR_CLIP_VALUE >= 0 ) ? ase_screenPosNorm97.z : ase_screenPosNorm97.z * 0.5 + 0.5;
				float screenDepth97 = LinearEyeDepth(SHADERGRAPH_SAMPLE_SCENE_DEPTH( ase_screenPosNorm97.xy ),_ZBufferParams);
				float distanceDepth97 = saturate( abs( ( screenDepth97 - LinearEyeDepth( ase_screenPosNorm97.z,_ZBufferParams ) ) / ( _Float16 ) ) );
				float depthfade_switch334 = _Float5;
				float lerpResult336 = lerp( distanceDepth97 , ( 1.0 - distanceDepth97 ) , depthfade_switch334);
				float depthfade126 = lerpResult336;
				float lerpResult330 = lerp( 0.0 , depthfade126 , depthfade_switch334);
				float2 appendResult440 = (float2(_Vector0.x , _Vector0.y));
				float2 uv_maintex = IN.ase_texcoord4.xy * _maintex_ST.xy + _maintex_ST.zw;
				float2 appendResult436 = (float2(( _Vector8.x - 1.0 ) , ( _Vector8.y - 1.0 )));
				float2 appendResult433 = (float2(_Vector8.z , _Vector8.w));
				float4 texCoord39 = IN.ase_texcoord5;
				texCoord39.xy = IN.ase_texcoord5.xy * float2( 1,1 ) + float2( 0,0 );
				float2 appendResult42 = (float2(texCoord39.x , texCoord39.y));
				float2 lerpResult59 = lerp( appendResult433 , appendResult42 , _Float10);
				float2 CenteredUV15_g18 = ( uv_maintex - float2( 0.5,0.5 ) );
				float2 break17_g18 = CenteredUV15_g18;
				float2 appendResult23_g18 = (float2(( length( CenteredUV15_g18 ) * _Vector8.x * 2.0 ) , ( atan2( break17_g18.x , break17_g18.y ) * ( 1.0 / TWO_PI ) * _Vector8.y )));
				float2 lerpResult449 = lerp( appendResult433 , appendResult42 , _Float10);
				float2 lerpResult609 = lerp( (uv_maintex*appendResult436 + ( uv_maintex + lerpResult59 )) , (appendResult23_g18*float2( 1,1 ) + lerpResult449) , _Float50);
				float2 panner36 = ( 1.0 * _Time.y * appendResult440 + lerpResult609);
				float2 maintexUV161 = panner36;
				float2 uv_TextureSample1 = IN.ase_texcoord4.xy * _TextureSample1_ST.xy + _TextureSample1_ST.zw;
				float2 CenteredUV15_g9 = ( uv_TextureSample1 - float2( 0.5,0.5 ) );
				float2 break17_g9 = CenteredUV15_g9;
				float2 appendResult23_g9 = (float2(( length( CenteredUV15_g9 ) * 1.0 * 2.0 ) , ( atan2( break17_g9.x , break17_g9.y ) * ( 1.0 / TWO_PI ) * 1.0 )));
				float2 lerpResult574 = lerp( uv_TextureSample1 , appendResult23_g9 , _Float54);
				float cos562 = cos( ( _Float57 * PI ) );
				float sin562 = sin( ( _Float57 * PI ) );
				float2 rotator562 = mul( lerpResult574 - float2( 0.5,0.5 ) , float2x2( cos562 , -sin562 , sin562 , cos562 )) + float2( 0.5,0.5 );
				float4 tex1DNode564 = tex1D( _TextureSample1, rotator562.x );
				float2 appendResult530 = (float2(_Vector17.x , _Vector17.y));
				float2 uv_noise = IN.ase_texcoord4.xy * _noise_ST.xy + _noise_ST.zw;
				float2 appendResult534 = (float2(( _Vector16.x - 1.0 ) , ( _Vector16.y - 1.0 )));
				float2 appendResult531 = (float2(_Vector16.z , _Vector16.w));
				float2 CenteredUV15_g6 = ( uv_noise - float2( 0.5,0.5 ) );
				float2 break17_g6 = CenteredUV15_g6;
				float2 appendResult23_g6 = (float2(( length( CenteredUV15_g6 ) * _Vector16.x * 2.0 ) , ( atan2( break17_g6.x , break17_g6.y ) * ( 1.0 / TWO_PI ) * _Vector16.y )));
				float2 lerpResult539 = lerp( (uv_noise*appendResult534 + ( uv_noise + appendResult531 )) , (appendResult23_g6*float2( 1,1 ) + appendResult531) , _Float54);
				float2 panner53 = ( 1.0 * _Time.y * appendResult530 + lerpResult539);
				float cos395 = cos( ( _Float44 * PI ) );
				float sin395 = sin( ( _Float44 * PI ) );
				float2 rotator395 = mul( panner53 - float2( 0.5,0.5 ) , float2x2( cos395 , -sin395 , sin395 , cos395 )) + float2( 0.5,0.5 );
				float2 break663 = rotator395;
				float clampResult664 = clamp( break663.x , 0.0 , 1.0 );
				float clampResult665 = clamp( break663.y , 0.0 , 1.0 );
				float2 appendResult666 = (float2(clampResult664 , clampResult665));
				#if defined(_KEYWORD14_REPEAT)
				float2 staticSwitch667 = rotator395;
				#elif defined(_KEYWORD14_CLAMP)
				float2 staticSwitch667 = appendResult666;
				#else
				float2 staticSwitch667 = rotator395;
				#endif
				float4 tex2DNode50 = tex2D( _noise, staticSwitch667 );
				#if defined(DOUBLENOISE_OFF)
				float staticSwitch683 = ( tex1DNode564.r * tex2DNode50.r );
				#elif defined(DOUBLENOISE_ON)
				float staticSwitch683 = ( tex1DNode564.r + tex2DNode50.r );
				#else
				float staticSwitch683 = ( tex1DNode564.r * tex2DNode50.r );
				#endif
				float noise70 = staticSwitch683;
				float noise_intensity_main67 = ( _Float9 * 0.1 );
				float2 uv_flowmaptex = IN.ase_texcoord4.xy * _flowmaptex_ST.xy + _flowmaptex_ST.zw;
				float4 tex2DNode241 = tex2D( _flowmaptex, uv_flowmaptex );
				float2 appendResult242 = (float2(tex2DNode241.r , tex2DNode241.g));
				float2 flowmap285 = appendResult242;
				float flowmap_intensity311 = _Float32;
				float4 texCoord100 = IN.ase_texcoord6;
				texCoord100.xy = IN.ase_texcoord6.xy * float2( 1,1 ) + float2( 0,0 );
				float flpwmap_custom_switch316 = _Float31;
				float lerpResult99 = lerp( flowmap_intensity311 , texCoord100.y , flpwmap_custom_switch316);
				float2 lerpResult283 = lerp( ( maintexUV161 + ( noise70 * noise_intensity_main67 ) ) , flowmap285 , lerpResult99);
				float cos377 = cos( ( _Float39 * PI ) );
				float sin377 = sin( ( _Float39 * PI ) );
				float2 rotator377 = mul( lerpResult283 - float2( 0.5,0.5 ) , float2x2( cos377 , -sin377 , sin377 , cos377 )) + float2( 0.5,0.5 );
				float2 break632 = rotator377;
				float clampResult633 = clamp( break632.x , 0.0 , 1.0 );
				float clampResult634 = clamp( break632.y , 0.0 , 1.0 );
				float2 appendResult635 = (float2(clampResult633 , clampResult634));
				#if defined(_KEYWORD8_REPEAT)
				float2 staticSwitch636 = rotator377;
				#elif defined(_KEYWORD8_CLAMP)
				float2 staticSwitch636 = appendResult635;
				#else
				float2 staticSwitch636 = rotator377;
				#endif
				float4 tex2DNode1 = tex2D( _maintex, staticSwitch636 );
				float2 appendResult464 = (float2(_Vector7.x , _Vector7.y));
				float2 uv_Gradienttex = IN.ase_texcoord4.xy * _Gradienttex_ST.xy + _Gradienttex_ST.zw;
				float2 appendResult454 = (float2(( _Vector9.x - 1.0 ) , ( _Vector9.y - 1.0 )));
				float2 appendResult457 = (float2(_Vector9.z , _Vector9.w));
				float2 CenteredUV15_g48 = ( uv_Gradienttex - float2( 0.5,0.5 ) );
				float2 break17_g48 = CenteredUV15_g48;
				float2 appendResult23_g48 = (float2(( length( CenteredUV15_g48 ) * _Vector9.x * 2.0 ) , ( atan2( break17_g48.x , break17_g48.y ) * ( 1.0 / TWO_PI ) * _Vector9.y )));
				float2 lerpResult611 = lerp( (uv_Gradienttex*appendResult454 + ( uv_Gradienttex + appendResult457 )) , (appendResult23_g48*float2( 1,1 ) + appendResult457) , _Float61);
				float2 panner229 = ( 1.0 * _Time.y * appendResult464 + lerpResult611);
				float2 Gradienttex231 = panner229;
				float2 temp_cast_1 = (noise70).xx;
				float2 lerpResult235 = lerp( Gradienttex231 , temp_cast_1 , noise_intensity_main67);
				float cos383 = cos( ( _Float40 * PI ) );
				float sin383 = sin( ( _Float40 * PI ) );
				float2 rotator383 = mul( lerpResult235 - float2( 0.5,0.5 ) , float2x2( cos383 , -sin383 , sin383 , cos383 )) + float2( 0.5,0.5 );
				float2 break637 = rotator383;
				float clampResult639 = clamp( break637.x , 0.0 , 1.0 );
				float clampResult638 = clamp( break637.y , 0.0 , 1.0 );
				float2 appendResult640 = (float2(clampResult639 , clampResult638));
				#if defined(_KEYWORD9_REPEAT)
				float2 staticSwitch641 = rotator383;
				#elif defined(_KEYWORD9_CLAMP)
				float2 staticSwitch641 = appendResult640;
				#else
				float2 staticSwitch641 = rotator383;
				#endif
				float4 tex2DNode212 = tex2D( _Gradienttex, staticSwitch641 );
				float4 temp_cast_2 = (tex2DNode212.r).xxxx;
				#if defined(_KEYWORD1_RGB)
				float4 staticSwitch716 = tex2DNode212;
				#elif defined(_KEYWORD1_R)
				float4 staticSwitch716 = temp_cast_2;
				#else
				float4 staticSwitch716 = tex2DNode212;
				#endif
				float4 temp_output_717_0 = ( staticSwitch716 * blendcolor );
				float4 lerpResult211 = lerp( tex2DNode1 , temp_output_717_0 , _Float29);
				#if defined(_KEYWORD3_LERP)
				float4 staticSwitch603 = lerpResult211;
				#elif defined(_KEYWORD3_MULTIPLY)
				float4 staticSwitch603 = ( tex2DNode1 * temp_output_717_0 );
				#else
				float4 staticSwitch603 = lerpResult211;
				#endif
				float4 lerpResult359 = lerp( _Color0 , _Color3 , _Float35);
				float4 switchResult356 = (((ase_vface>0)?(_Color0):(lerpResult359)));
				float3 ase_worldViewDir = ( _WorldSpaceCameraPos.xyz - WorldPosition );
				ase_worldViewDir = SafeNormalize( ase_worldViewDir );
				float3 ase_worldNormal = IN.ase_texcoord7.xyz;
				float3 normalizedWorldNormal = normalize( ase_worldNormal );
				float fresnelNdotV139 = dot( normalize( ( normalizedWorldNormal * ase_vface ) ), ase_worldViewDir );
				float fresnelNode139 = ( 0.0 + _power3 * pow( max( 1.0 - fresnelNdotV139 , 0.0001 ), _Float19 ) );
				float temp_output_140_0 = saturate( fresnelNode139 );
				float lerpResult144 = lerp( temp_output_140_0 , ( 1.0 - temp_output_140_0 ) , _Float20);
				float fresnel147 = lerpResult144;
				#if defined(_KEYWORD5_OFF)
				float staticSwitch615 = 1.0;
				#elif defined(_KEYWORD5_ON)
				float staticSwitch615 = fresnel147;
				#else
				float staticSwitch615 = 1.0;
				#endif
				#if defined(_KEYWORD0_A)
				float staticSwitch599 = tex2DNode1.a;
				#elif defined(_KEYWORD0_R)
				float staticSwitch599 = tex2DNode1.r;
				#else
				float staticSwitch599 = tex2DNode1.a;
				#endif
				float lerpResult374 = lerp( staticSwitch599 , ( pow( staticSwitch599 , _Float34 ) * _Float37 ) , _Float36);
				float2 appendResult480 = (float2(_Vector11.x , _Vector11.y));
				float2 uv_Mask = IN.ase_texcoord4.xy * _Mask_ST.xy + _Mask_ST.zw;
				float2 appendResult473 = (float2(( _Vector10.x - 1.0 ) , ( _Vector10.y - 1.0 )));
				float2 appendResult481 = (float2(_Vector10.z , _Vector10.w));
				float4 texCoord74 = IN.ase_texcoord5;
				texCoord74.xy = IN.ase_texcoord5.xy * float2( 1,1 ) + float2( 0,0 );
				float2 appendResult75 = (float2(texCoord74.z , texCoord74.w));
				float2 lerpResult474 = lerp( appendResult481 , appendResult75 , _Float12);
				float2 CenteredUV15_g42 = ( uv_Mask - float2( 0.5,0.5 ) );
				float2 break17_g42 = CenteredUV15_g42;
				float2 appendResult23_g42 = (float2(( length( CenteredUV15_g42 ) * _Vector10.x * 2.0 ) , ( atan2( break17_g42.x , break17_g42.y ) * ( 1.0 / TWO_PI ) * _Vector10.y )));
				float2 lerpResult471 = lerp( appendResult481 , appendResult75 , _Float12);
				float2 lerpResult467 = lerp( (uv_Mask*appendResult473 + ( uv_Mask + lerpResult474 )) , (appendResult23_g42*float2( 1,1 ) + lerpResult471) , _Float51);
				float2 panner79 = ( 1.0 * _Time.y * appendResult480 + lerpResult467);
				float noise_intensity_mask675 = ( _Float18 * 0.1 );
				float temp_output_322_0 = ( noise70 * noise_intensity_mask675 );
				float cos392 = cos( ( _Float43 * PI ) );
				float sin392 = sin( ( _Float43 * PI ) );
				float2 rotator392 = mul( ( panner79 + temp_output_322_0 ) - float2( 0.5,0.5 ) , float2x2( cos392 , -sin392 , sin392 , cos392 )) + float2( 0.5,0.5 );
				float2 break642 = rotator392;
				float clampResult644 = clamp( break642.x , 0.0 , 1.0 );
				float clampResult643 = clamp( break642.y , 0.0 , 1.0 );
				float2 appendResult645 = (float2(clampResult644 , clampResult643));
				#if defined(_KEYWORD10_REPEAT)
				float2 staticSwitch646 = rotator392;
				#elif defined(_KEYWORD10_CLAMP)
				float2 staticSwitch646 = appendResult645;
				#else
				float2 staticSwitch646 = rotator392;
				#endif
				float4 tex2DNode8 = tex2D( _Mask, staticSwitch646 );
				float4 texCoord49 = IN.ase_texcoord6;
				texCoord49.xy = IN.ase_texcoord6.xy * float2( 1,1 ) + float2( 0,0 );
				float lerpResult62 = lerp( _Float6 , ( 1.0 - texCoord49.x ) , _Float11);
				float2 uv_TextureSample0 = IN.ase_texcoord4.xy * _TextureSample0_ST.xy + _TextureSample0_ST.zw;
				float2 CenteredUV15_g43 = ( uv_TextureSample0 - float2( 0.5,0.5 ) );
				float2 break17_g43 = CenteredUV15_g43;
				float2 appendResult23_g43 = (float2(( length( CenteredUV15_g43 ) * 1.0 * 2.0 ) , ( atan2( break17_g43.x , break17_g43.y ) * ( 1.0 / TWO_PI ) * 1.0 )));
				float2 lerpResult568 = lerp( uv_TextureSample0 , appendResult23_g43 , _Float53);
				float cos417 = cos( ( _Float47 * PI ) );
				float sin417 = sin( ( _Float47 * PI ) );
				float2 rotator417 = mul( lerpResult568 - float2( 0.5,0.5 ) , float2x2( cos417 , -sin417 , sin417 , cos417 )) + float2( 0.5,0.5 );
				float dis_direction277 = tex2D( _TextureSample0, rotator417 ).r;
				float2 appendResult501 = (float2(_Vector15.x , _Vector15.y));
				float2 uv_dissolvetex = IN.ase_texcoord4.xy * _dissolvetex_ST.xy + _dissolvetex_ST.zw;
				float2 appendResult505 = (float2(( _Vector14.x - 1.0 ) , ( _Vector14.y - 1.0 )));
				float2 appendResult502 = (float2(_Vector14.z , _Vector14.w));
				float2 CenteredUV15_g10 = ( uv_dissolvetex - float2( 0.5,0.5 ) );
				float2 break17_g10 = CenteredUV15_g10;
				float2 appendResult23_g10 = (float2(( length( CenteredUV15_g10 ) * _Vector14.x * 2.0 ) , ( atan2( break17_g10.x , break17_g10.y ) * ( 1.0 / TWO_PI ) * _Vector14.y )));
				float2 lerpResult511 = lerp( (uv_dissolvetex*appendResult505 + ( uv_dissolvetex + appendResult502 )) , (appendResult23_g10*float2( 1,1 ) + appendResult502) , _Float53);
				float2 panner58 = ( 1.0 * _Time.y * appendResult501 + lerpResult511);
				float noise_intensity_dis678 = ( _Float33 * 0.1 );
				float4 texCoord303 = IN.ase_texcoord6;
				texCoord303.xy = IN.ase_texcoord6.xy * float2( 1,1 ) + float2( 0,0 );
				float lerpResult307 = lerp( flowmap_intensity311 , texCoord303.y , flpwmap_custom_switch316);
				float2 lerpResult309 = lerp( ( panner58 + ( noise70 * noise_intensity_dis678 ) ) , flowmap285 , lerpResult307);
				float2 dissolveUV92 = lerpResult309;
				float cos386 = cos( ( _Float41 * PI ) );
				float sin386 = sin( ( _Float41 * PI ) );
				float2 rotator386 = mul( dissolveUV92 - float2( 0.5,0.5 ) , float2x2( cos386 , -sin386 , sin386 , cos386 )) + float2( 0.5,0.5 );
				float2 break652 = rotator386;
				float clampResult654 = clamp( break652.x , 0.0 , 1.0 );
				float clampResult653 = clamp( break652.y , 0.0 , 1.0 );
				float2 appendResult655 = (float2(clampResult654 , clampResult653));
				#if defined(_KEYWORD12_REPEAT)
				float2 staticSwitch656 = rotator386;
				#elif defined(_KEYWORD12_CLAMP)
				float2 staticSwitch656 = appendResult655;
				#else
				float2 staticSwitch656 = rotator386;
				#endif
				float temp_output_280_0 = ( dis_direction277 * tex2D( _dissolvetex, staticSwitch656 ).r );
				float temp_output_130_0 = (0.0 + (temp_output_280_0 - -0.5) * (1.0 - 0.0) / (1.5 - -0.5));
				float temp_output_105_0 = step( lerpResult62 , temp_output_130_0 );
				float dis_edge133 = ( temp_output_105_0 - step( ( lerpResult62 + _Float17 ) , temp_output_130_0 ) );
				float4 lerpResult131 = lerp( ( ( ( _Float28 * pow( lerpResult330 , _Float30 ) ) + staticSwitch603 ) * IN.ase_color * switchResult356 * _Float14 * staticSwitch615 * lerpResult374 * tex2DNode8 ) , _Color1 , dis_edge133);
				
				float smoothstepResult32 = smoothstep( ( 1.0 - _Float8 ) , _Float8 , saturate( ( ( temp_output_280_0 + 1.0 ) - ( lerpResult62 * 2.0 ) ) ));
				float dis_soft122 = smoothstepResult32;
				float dis_bright124 = temp_output_105_0;
				float lerpResult413 = lerp( dis_soft122 , dis_bright124 , _Float25);
				float lerpResult338 = lerp( depthfade126 , 1.0 , depthfade_switch334);
				#if defined(_KEYWORD4_A)
				float staticSwitch606 = tex2DNode8.a;
				#elif defined(_KEYWORD4_R)
				float staticSwitch606 = tex2DNode8.r;
				#else
				float staticSwitch606 = tex2DNode8.a;
				#endif
				float2 appendResult485 = (float2(_Vector13.x , _Vector13.y));
				float2 uv_Mask1 = IN.ase_texcoord4.xy * _Mask1_ST.xy + _Mask1_ST.zw;
				float2 appendResult489 = (float2(( _Vector12.x - 1.0 ) , ( _Vector12.y - 1.0 )));
				float2 appendResult486 = (float2(_Vector12.z , _Vector12.w));
				float2 CenteredUV15_g41 = ( uv_Mask1 - float2( 0.5,0.5 ) );
				float2 break17_g41 = CenteredUV15_g41;
				float2 appendResult23_g41 = (float2(( length( CenteredUV15_g41 ) * _Vector12.x * 2.0 ) , ( atan2( break17_g41.x , break17_g41.y ) * ( 1.0 / TWO_PI ) * _Vector12.y )));
				float2 lerpResult495 = lerp( (uv_Mask1*appendResult489 + ( uv_Mask1 + appendResult486 )) , (appendResult23_g41*float2( 1,1 ) + appendResult486) , _Float52);
				float2 panner216 = ( 1.0 * _Time.y * appendResult485 + lerpResult495);
				float cos389 = cos( ( _Float42 * PI ) );
				float sin389 = sin( ( _Float42 * PI ) );
				float2 rotator389 = mul( ( temp_output_322_0 + panner216 ) - float2( 0.5,0.5 ) , float2x2( cos389 , -sin389 , sin389 , cos389 )) + float2( 0.5,0.5 );
				float2 break647 = rotator389;
				float clampResult649 = clamp( break647.x , 0.0 , 1.0 );
				float clampResult648 = clamp( break647.y , 0.0 , 1.0 );
				float2 appendResult650 = (float2(clampResult649 , clampResult648));
				#if defined(_KEYWORD11_REPEAT)
				float2 staticSwitch651 = rotator389;
				#elif defined(_KEYWORD11_CLAMP)
				float2 staticSwitch651 = appendResult650;
				#else
				float2 staticSwitch651 = rotator389;
				#endif
				float4 tex2DNode218 = tex2D( _Mask1, staticSwitch651 );
				#if defined(_KEYWORD6_A)
				float staticSwitch608 = tex2DNode218.a;
				#elif defined(_KEYWORD6_R)
				float staticSwitch608 = tex2DNode218.r;
				#else
				float staticSwitch608 = tex2DNode218.a;
				#endif
				float Mask82 = ( staticSwitch606 * staticSwitch608 );
				float temp_output_6_0 = ( lerpResult374 * IN.ase_color.a * _Color0.a * lerpResult413 * _Float15 * lerpResult338 * Mask82 * staticSwitch615 );
				float clampResult616 = clamp( temp_output_6_0 , 0.0 , 1.0 );
				#if defined(_KEYWORD7_OFF)
				float staticSwitch617 = temp_output_6_0;
				#elif defined(_KEYWORD7_ON)
				float staticSwitch617 = clampResult616;
				#else
				float staticSwitch617 = temp_output_6_0;
				#endif
				
				float3 BakedAlbedo = 0;
				float3 BakedEmission = 0;
				float3 Color = lerpResult131.rgb;
				float Alpha = staticSwitch617;
				float AlphaClipThreshold = 0.5;
				float AlphaClipThresholdShadow = 0.5;

				#ifdef _ALPHATEST_ON
					clip( Alpha - AlphaClipThreshold );
				#endif

				#ifdef LOD_FADE_CROSSFADE
					LODDitheringTransition( IN.clipPos.xyz, unity_LODFade.x );
				#endif

				#ifdef ASE_FOG
					Color = MixFog( Color, IN.fogFactor );
				#endif

				return half4( Color, Alpha );
			}

			ENDHLSL
		}

		
		Pass
		{
			
			Name "DepthOnly"
			Tags { "LightMode"="DepthOnly" }

			ZWrite On
			ColorMask 0
			AlphaToMask Off

			HLSLPROGRAM
			
			#define _RECEIVE_SHADOWS_OFF 1
			#define ASE_SRP_VERSION 100801
			#define REQUIRE_DEPTH_TEXTURE 1

			
			#pragma vertex vert
			#pragma fragment frag

			#include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
			#include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Lighting.hlsl"
			#include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/ShaderGraphFunctions.hlsl"
			#include "Packages/com.unity.render-pipelines.core/ShaderLibrary/Color.hlsl"

			#define ASE_NEEDS_VERT_NORMAL
			#define ASE_NEEDS_VERT_POSITION
			#define ASE_NEEDS_FRAG_WORLD_POSITION
			#define ASE_NEEDS_FRAG_COLOR
			#pragma shader_feature_local _KEYWORD13_REPEAT _KEYWORD13_CLAMP
			#pragma shader_feature_local _KEYWORD16_REPEAT _KEYWORD16_CLAMP
			#pragma shader_feature_local _KEYWORD7_OFF _KEYWORD7_ON
			#pragma shader_feature_local _KEYWORD0_A _KEYWORD0_R
			#pragma shader_feature_local _KEYWORD8_REPEAT _KEYWORD8_CLAMP
			#pragma shader_feature_local DOUBLENOISE_OFF DOUBLENOISE_ON
			#pragma shader_feature_local _KEYWORD14_REPEAT _KEYWORD14_CLAMP
			#pragma shader_feature_local _KEYWORD12_REPEAT _KEYWORD12_CLAMP
			#pragma shader_feature_local _KEYWORD4_A _KEYWORD4_R
			#pragma shader_feature_local _KEYWORD10_REPEAT _KEYWORD10_CLAMP
			#pragma shader_feature_local _KEYWORD6_A _KEYWORD6_R
			#pragma shader_feature_local _KEYWORD11_REPEAT _KEYWORD11_CLAMP
			#pragma shader_feature_local _KEYWORD5_OFF _KEYWORD5_ON


			struct VertexInput
			{
				float4 vertex : POSITION;
				float3 ase_normal : NORMAL;
				float4 ase_texcoord : TEXCOORD0;
				float4 ase_texcoord2 : TEXCOORD2;
				float4 ase_texcoord1 : TEXCOORD1;
				float4 ase_color : COLOR;
				UNITY_VERTEX_INPUT_INSTANCE_ID
			};

			struct VertexOutput
			{
				float4 clipPos : SV_POSITION;
				#if defined(ASE_NEEDS_FRAG_WORLD_POSITION)
				float3 worldPos : TEXCOORD0;
				#endif
				#if defined(REQUIRES_VERTEX_SHADOW_COORD_INTERPOLATOR) && defined(ASE_NEEDS_FRAG_SHADOWCOORDS)
				float4 shadowCoord : TEXCOORD1;
				#endif
				float4 ase_texcoord2 : TEXCOORD2;
				float4 ase_texcoord3 : TEXCOORD3;
				float4 ase_texcoord4 : TEXCOORD4;
				float4 ase_color : COLOR;
				float4 ase_texcoord5 : TEXCOORD5;
				float4 ase_texcoord6 : TEXCOORD6;
				UNITY_VERTEX_INPUT_INSTANCE_ID
				UNITY_VERTEX_OUTPUT_STEREO
			};

			CBUFFER_START(UnityPerMaterial)
			float4 _Gradienttex_ST;
			float4 _Color3;
			float4 _Vector8;
			float4 _Color1;
			float4 _TextureSample1_ST;
			float4 _Vector17;
			float4 _noise_ST;
			float4 _Vector16;
			float4 _Vector10;
			float4 _flowmaptex_ST;
			float4 _Mask_ST;
			float4 _Vector11;
			float4 _Vector7;
			float4 _Vector9;
			float4 blendcolor;
			float4 _Color0;
			float4 _Vector0;
			float4 _TextureSample0_ST;
			float4 _maintex_ST;
			float4 _Vector19;
			float4 _Vector12;
			float4 _Vector22;
			float4 _Mask1_ST;
			float4 _Vector23;
			float4 _dissolvetex_ST;
			float4 _Vector14;
			float4 _Vector15;
			float4 _vertextex_ST;
			float4 _Vector13;
			float4 _Vector18;
			float3 _Vector5;
			float _Float15;
			float _Float20;
			float _Float34;
			float _Float36;
			float _Float19;
			float _Float37;
			float _Float25;
			float _Float47;
			float _Float17;
			float _Float41;
			float _Float12;
			float _Float51;
			float _Float18;
			float _Float33;
			float _Float43;
			float _Float6;
			float _Float11;
			float _Float53;
			float _Float8;
			float _power3;
			float _Float2;
			float _Float35;
			float _Ztestmode1;
			float _Float60;
			float _Float1;
			float _Ztestmode;
			float _Ztestmode2;
			float _Float46;
			float _Float4;
			float _Float24;
			float _Float56;
			float _Float45;
			float _Float22;
			float _Float62;
			float _Float48;
			float _Float28;
			float _Float14;
			float _Float16;
			float _Float30;
			float _Float10;
			float _Float50;
			float _Float54;
			float _Float57;
			float _Float44;
			float _Float9;
			float _Float32;
			float _Float31;
			float _Float39;
			float _Float52;
			float _Float61;
			float _Float40;
			float _Float29;
			float _Float5;
			float _Float42;
			#ifdef TESSELLATION_ON
				float _TessPhongStrength;
				float _TessValue;
				float _TessMin;
				float _TessMax;
				float _TessEdgeLength;
				float _TessMaxDisp;
			#endif
			CBUFFER_END
			sampler2D _vertextex;
			sampler2D _vertextex1;
			sampler2D _maintex;
			sampler1D _TextureSample1;
			sampler2D _noise;
			sampler2D _flowmaptex;
			sampler2D _TextureSample0;
			sampler2D _dissolvetex;
			uniform float4 _CameraDepthTexture_TexelSize;
			sampler2D _Mask;
			sampler2D _Mask1;


			
			VertexOutput VertexFunction( VertexInput v  )
			{
				VertexOutput o = (VertexOutput)0;
				UNITY_SETUP_INSTANCE_ID(v);
				UNITY_TRANSFER_INSTANCE_ID(v, o);
				UNITY_INITIALIZE_VERTEX_OUTPUT_STEREO(o);

				float2 appendResult557 = (float2(_Vector19.x , _Vector19.y));
				float2 uv_vertextex = v.ase_texcoord.xy * _vertextex_ST.xy + _vertextex_ST.zw;
				float2 appendResult550 = (float2(( _Vector18.x - 1.0 ) , ( _Vector18.y - 1.0 )));
				float2 appendResult546 = (float2(_Vector18.z , _Vector18.w));
				float2 CenteredUV15_g44 = ( uv_vertextex - float2( 0.5,0.5 ) );
				float2 break17_g44 = CenteredUV15_g44;
				float2 appendResult23_g44 = (float2(( length( CenteredUV15_g44 ) * _Vector18.x * 2.0 ) , ( atan2( break17_g44.x , break17_g44.y ) * ( 1.0 / TWO_PI ) * _Vector18.y )));
				float2 lerpResult556 = lerp( (uv_vertextex*appendResult550 + ( uv_vertextex + appendResult546 )) , (appendResult23_g44*float2( 1,1 ) + appendResult546) , _Float56);
				float2 panner168 = ( 1.0 * _Time.y * appendResult557 + lerpResult556);
				float cos398 = cos( ( _Float45 * PI ) );
				float sin398 = sin( ( _Float45 * PI ) );
				float2 rotator398 = mul( panner168 - float2( 0.5,0.5 ) , float2x2( cos398 , -sin398 , sin398 , cos398 )) + float2( 0.5,0.5 );
				float2 break658 = rotator398;
				float clampResult659 = clamp( break658.x , 0.0 , 1.0 );
				float clampResult660 = clamp( break658.y , 0.0 , 1.0 );
				float2 appendResult661 = (float2(clampResult659 , clampResult660));
				#if defined(_KEYWORD13_REPEAT)
				float2 staticSwitch662 = rotator398;
				#elif defined(_KEYWORD13_CLAMP)
				float2 staticSwitch662 = appendResult661;
				#else
				float2 staticSwitch662 = rotator398;
				#endif
				float4 texCoord167 = v.ase_texcoord2;
				texCoord167.xy = v.ase_texcoord2.xy * float2( 1,1 ) + float2( 0,0 );
				float lerpResult176 = lerp( 1.0 , texCoord167.w , _Float22);
				float2 appendResult698 = (float2(_Vector23.x , _Vector23.y));
				float2 appendResult691 = (float2(( _Vector22.x - 1.0 ) , ( _Vector22.y - 1.0 )));
				float2 appendResult686 = (float2(_Vector22.z , _Vector22.w));
				float2 CenteredUV15_g45 = ( uv_vertextex - float2( 0.5,0.5 ) );
				float2 break17_g45 = CenteredUV15_g45;
				float2 appendResult23_g45 = (float2(( length( CenteredUV15_g45 ) * _Vector22.x * 2.0 ) , ( atan2( break17_g45.x , break17_g45.y ) * ( 1.0 / TWO_PI ) * _Vector22.y )));
				float2 lerpResult697 = lerp( (uv_vertextex*appendResult691 + ( uv_vertextex + appendResult686 )) , (appendResult23_g45*float2( 1,1 ) + appendResult686) , _Float62);
				float2 panner700 = ( 1.0 * _Time.y * appendResult698 + lerpResult697);
				float cos701 = cos( ( _Float48 * PI ) );
				float sin701 = sin( ( _Float48 * PI ) );
				float2 rotator701 = mul( panner700 - float2( 0.5,0.5 ) , float2x2( cos701 , -sin701 , sin701 , cos701 )) + float2( 0.5,0.5 );
				float2 break702 = rotator701;
				float clampResult704 = clamp( break702.x , 0.0 , 1.0 );
				float clampResult703 = clamp( break702.y , 0.0 , 1.0 );
				float2 appendResult705 = (float2(clampResult704 , clampResult703));
				#if defined(_KEYWORD16_REPEAT)
				float2 staticSwitch706 = rotator701;
				#elif defined(_KEYWORD16_CLAMP)
				float2 staticSwitch706 = appendResult705;
				#else
				float2 staticSwitch706 = rotator701;
				#endif
				float3 vertexoffset181 = ( tex2Dlod( _vertextex, float4( staticSwitch662, 0, 0.0) ).r * v.ase_normal * _Vector5 * lerpResult176 * tex2Dlod( _vertextex1, float4( staticSwitch706, 0, 0.0) ).r );
				
				float3 vertexPos97 = v.vertex.xyz;
				float4 ase_clipPos97 = TransformObjectToHClip((vertexPos97).xyz);
				float4 screenPos97 = ComputeScreenPos(ase_clipPos97);
				o.ase_texcoord5 = screenPos97;
				float3 ase_worldNormal = TransformObjectToWorldNormal(v.ase_normal);
				o.ase_texcoord6.xyz = ase_worldNormal;
				
				o.ase_texcoord2.xy = v.ase_texcoord.xy;
				o.ase_texcoord3 = v.ase_texcoord1;
				o.ase_texcoord4 = v.ase_texcoord2;
				o.ase_color = v.ase_color;
				
				//setting value to unused interpolator channels and avoid initialization warnings
				o.ase_texcoord2.zw = 0;
				o.ase_texcoord6.w = 0;
				#ifdef ASE_ABSOLUTE_VERTEX_POS
					float3 defaultVertexValue = v.vertex.xyz;
				#else
					float3 defaultVertexValue = float3(0, 0, 0);
				#endif
				float3 vertexValue = vertexoffset181;
				#ifdef ASE_ABSOLUTE_VERTEX_POS
					v.vertex.xyz = vertexValue;
				#else
					v.vertex.xyz += vertexValue;
				#endif

				v.ase_normal = v.ase_normal;

				float3 positionWS = TransformObjectToWorld( v.vertex.xyz );

				#if defined(ASE_NEEDS_FRAG_WORLD_POSITION)
				o.worldPos = positionWS;
				#endif

				o.clipPos = TransformWorldToHClip( positionWS );
				#if defined(REQUIRES_VERTEX_SHADOW_COORD_INTERPOLATOR) && defined(ASE_NEEDS_FRAG_SHADOWCOORDS)
					VertexPositionInputs vertexInput = (VertexPositionInputs)0;
					vertexInput.positionWS = positionWS;
					vertexInput.positionCS = o.clipPos;
					o.shadowCoord = GetShadowCoord( vertexInput );
				#endif
				return o;
			}

			#if defined(TESSELLATION_ON)
			struct VertexControl
			{
				float4 vertex : INTERNALTESSPOS;
				float3 ase_normal : NORMAL;
				float4 ase_texcoord : TEXCOORD0;
				float4 ase_texcoord2 : TEXCOORD2;
				float4 ase_texcoord1 : TEXCOORD1;
				float4 ase_color : COLOR;

				UNITY_VERTEX_INPUT_INSTANCE_ID
			};

			struct TessellationFactors
			{
				float edge[3] : SV_TessFactor;
				float inside : SV_InsideTessFactor;
			};

			VertexControl vert ( VertexInput v )
			{
				VertexControl o;
				UNITY_SETUP_INSTANCE_ID(v);
				UNITY_TRANSFER_INSTANCE_ID(v, o);
				o.vertex = v.vertex;
				o.ase_normal = v.ase_normal;
				o.ase_texcoord = v.ase_texcoord;
				o.ase_texcoord2 = v.ase_texcoord2;
				o.ase_texcoord1 = v.ase_texcoord1;
				o.ase_color = v.ase_color;
				return o;
			}

			TessellationFactors TessellationFunction (InputPatch<VertexControl,3> v)
			{
				TessellationFactors o;
				float4 tf = 1;
				float tessValue = _TessValue; float tessMin = _TessMin; float tessMax = _TessMax;
				float edgeLength = _TessEdgeLength; float tessMaxDisp = _TessMaxDisp;
				#if defined(ASE_FIXED_TESSELLATION)
				tf = FixedTess( tessValue );
				#elif defined(ASE_DISTANCE_TESSELLATION)
				tf = DistanceBasedTess(v[0].vertex, v[1].vertex, v[2].vertex, tessValue, tessMin, tessMax, GetObjectToWorldMatrix(), _WorldSpaceCameraPos );
				#elif defined(ASE_LENGTH_TESSELLATION)
				tf = EdgeLengthBasedTess(v[0].vertex, v[1].vertex, v[2].vertex, edgeLength, GetObjectToWorldMatrix(), _WorldSpaceCameraPos, _ScreenParams );
				#elif defined(ASE_LENGTH_CULL_TESSELLATION)
				tf = EdgeLengthBasedTessCull(v[0].vertex, v[1].vertex, v[2].vertex, edgeLength, tessMaxDisp, GetObjectToWorldMatrix(), _WorldSpaceCameraPos, _ScreenParams, unity_CameraWorldClipPlanes );
				#endif
				o.edge[0] = tf.x; o.edge[1] = tf.y; o.edge[2] = tf.z; o.inside = tf.w;
				return o;
			}

			[domain("tri")]
			[partitioning("fractional_odd")]
			[outputtopology("triangle_cw")]
			[patchconstantfunc("TessellationFunction")]
			[outputcontrolpoints(3)]
			VertexControl HullFunction(InputPatch<VertexControl, 3> patch, uint id : SV_OutputControlPointID)
			{
			   return patch[id];
			}

			[domain("tri")]
			VertexOutput DomainFunction(TessellationFactors factors, OutputPatch<VertexControl, 3> patch, float3 bary : SV_DomainLocation)
			{
				VertexInput o = (VertexInput) 0;
				o.vertex = patch[0].vertex * bary.x + patch[1].vertex * bary.y + patch[2].vertex * bary.z;
				o.ase_normal = patch[0].ase_normal * bary.x + patch[1].ase_normal * bary.y + patch[2].ase_normal * bary.z;
				o.ase_texcoord = patch[0].ase_texcoord * bary.x + patch[1].ase_texcoord * bary.y + patch[2].ase_texcoord * bary.z;
				o.ase_texcoord2 = patch[0].ase_texcoord2 * bary.x + patch[1].ase_texcoord2 * bary.y + patch[2].ase_texcoord2 * bary.z;
				o.ase_texcoord1 = patch[0].ase_texcoord1 * bary.x + patch[1].ase_texcoord1 * bary.y + patch[2].ase_texcoord1 * bary.z;
				o.ase_color = patch[0].ase_color * bary.x + patch[1].ase_color * bary.y + patch[2].ase_color * bary.z;
				#if defined(ASE_PHONG_TESSELLATION)
				float3 pp[3];
				for (int i = 0; i < 3; ++i)
					pp[i] = o.vertex.xyz - patch[i].ase_normal * (dot(o.vertex.xyz, patch[i].ase_normal) - dot(patch[i].vertex.xyz, patch[i].ase_normal));
				float phongStrength = _TessPhongStrength;
				o.vertex.xyz = phongStrength * (pp[0]*bary.x + pp[1]*bary.y + pp[2]*bary.z) + (1.0f-phongStrength) * o.vertex.xyz;
				#endif
				UNITY_TRANSFER_INSTANCE_ID(patch[0], o);
				return VertexFunction(o);
			}
			#else
			VertexOutput vert ( VertexInput v )
			{
				return VertexFunction( v );
			}
			#endif

			half4 frag(VertexOutput IN , FRONT_FACE_TYPE ase_vface : FRONT_FACE_SEMANTIC ) : SV_TARGET
			{
				UNITY_SETUP_INSTANCE_ID(IN);
				UNITY_SETUP_STEREO_EYE_INDEX_POST_VERTEX( IN );

				#if defined(ASE_NEEDS_FRAG_WORLD_POSITION)
				float3 WorldPosition = IN.worldPos;
				#endif
				float4 ShadowCoords = float4( 0, 0, 0, 0 );

				#if defined(ASE_NEEDS_FRAG_SHADOWCOORDS)
					#if defined(REQUIRES_VERTEX_SHADOW_COORD_INTERPOLATOR)
						ShadowCoords = IN.shadowCoord;
					#elif defined(MAIN_LIGHT_CALCULATE_SHADOWS)
						ShadowCoords = TransformWorldToShadowCoord( WorldPosition );
					#endif
				#endif

				float2 appendResult440 = (float2(_Vector0.x , _Vector0.y));
				float2 uv_maintex = IN.ase_texcoord2.xy * _maintex_ST.xy + _maintex_ST.zw;
				float2 appendResult436 = (float2(( _Vector8.x - 1.0 ) , ( _Vector8.y - 1.0 )));
				float2 appendResult433 = (float2(_Vector8.z , _Vector8.w));
				float4 texCoord39 = IN.ase_texcoord3;
				texCoord39.xy = IN.ase_texcoord3.xy * float2( 1,1 ) + float2( 0,0 );
				float2 appendResult42 = (float2(texCoord39.x , texCoord39.y));
				float2 lerpResult59 = lerp( appendResult433 , appendResult42 , _Float10);
				float2 CenteredUV15_g18 = ( uv_maintex - float2( 0.5,0.5 ) );
				float2 break17_g18 = CenteredUV15_g18;
				float2 appendResult23_g18 = (float2(( length( CenteredUV15_g18 ) * _Vector8.x * 2.0 ) , ( atan2( break17_g18.x , break17_g18.y ) * ( 1.0 / TWO_PI ) * _Vector8.y )));
				float2 lerpResult449 = lerp( appendResult433 , appendResult42 , _Float10);
				float2 lerpResult609 = lerp( (uv_maintex*appendResult436 + ( uv_maintex + lerpResult59 )) , (appendResult23_g18*float2( 1,1 ) + lerpResult449) , _Float50);
				float2 panner36 = ( 1.0 * _Time.y * appendResult440 + lerpResult609);
				float2 maintexUV161 = panner36;
				float2 uv_TextureSample1 = IN.ase_texcoord2.xy * _TextureSample1_ST.xy + _TextureSample1_ST.zw;
				float2 CenteredUV15_g9 = ( uv_TextureSample1 - float2( 0.5,0.5 ) );
				float2 break17_g9 = CenteredUV15_g9;
				float2 appendResult23_g9 = (float2(( length( CenteredUV15_g9 ) * 1.0 * 2.0 ) , ( atan2( break17_g9.x , break17_g9.y ) * ( 1.0 / TWO_PI ) * 1.0 )));
				float2 lerpResult574 = lerp( uv_TextureSample1 , appendResult23_g9 , _Float54);
				float cos562 = cos( ( _Float57 * PI ) );
				float sin562 = sin( ( _Float57 * PI ) );
				float2 rotator562 = mul( lerpResult574 - float2( 0.5,0.5 ) , float2x2( cos562 , -sin562 , sin562 , cos562 )) + float2( 0.5,0.5 );
				float4 tex1DNode564 = tex1D( _TextureSample1, rotator562.x );
				float2 appendResult530 = (float2(_Vector17.x , _Vector17.y));
				float2 uv_noise = IN.ase_texcoord2.xy * _noise_ST.xy + _noise_ST.zw;
				float2 appendResult534 = (float2(( _Vector16.x - 1.0 ) , ( _Vector16.y - 1.0 )));
				float2 appendResult531 = (float2(_Vector16.z , _Vector16.w));
				float2 CenteredUV15_g6 = ( uv_noise - float2( 0.5,0.5 ) );
				float2 break17_g6 = CenteredUV15_g6;
				float2 appendResult23_g6 = (float2(( length( CenteredUV15_g6 ) * _Vector16.x * 2.0 ) , ( atan2( break17_g6.x , break17_g6.y ) * ( 1.0 / TWO_PI ) * _Vector16.y )));
				float2 lerpResult539 = lerp( (uv_noise*appendResult534 + ( uv_noise + appendResult531 )) , (appendResult23_g6*float2( 1,1 ) + appendResult531) , _Float54);
				float2 panner53 = ( 1.0 * _Time.y * appendResult530 + lerpResult539);
				float cos395 = cos( ( _Float44 * PI ) );
				float sin395 = sin( ( _Float44 * PI ) );
				float2 rotator395 = mul( panner53 - float2( 0.5,0.5 ) , float2x2( cos395 , -sin395 , sin395 , cos395 )) + float2( 0.5,0.5 );
				float2 break663 = rotator395;
				float clampResult664 = clamp( break663.x , 0.0 , 1.0 );
				float clampResult665 = clamp( break663.y , 0.0 , 1.0 );
				float2 appendResult666 = (float2(clampResult664 , clampResult665));
				#if defined(_KEYWORD14_REPEAT)
				float2 staticSwitch667 = rotator395;
				#elif defined(_KEYWORD14_CLAMP)
				float2 staticSwitch667 = appendResult666;
				#else
				float2 staticSwitch667 = rotator395;
				#endif
				float4 tex2DNode50 = tex2D( _noise, staticSwitch667 );
				#if defined(DOUBLENOISE_OFF)
				float staticSwitch683 = ( tex1DNode564.r * tex2DNode50.r );
				#elif defined(DOUBLENOISE_ON)
				float staticSwitch683 = ( tex1DNode564.r + tex2DNode50.r );
				#else
				float staticSwitch683 = ( tex1DNode564.r * tex2DNode50.r );
				#endif
				float noise70 = staticSwitch683;
				float noise_intensity_main67 = ( _Float9 * 0.1 );
				float2 uv_flowmaptex = IN.ase_texcoord2.xy * _flowmaptex_ST.xy + _flowmaptex_ST.zw;
				float4 tex2DNode241 = tex2D( _flowmaptex, uv_flowmaptex );
				float2 appendResult242 = (float2(tex2DNode241.r , tex2DNode241.g));
				float2 flowmap285 = appendResult242;
				float flowmap_intensity311 = _Float32;
				float4 texCoord100 = IN.ase_texcoord4;
				texCoord100.xy = IN.ase_texcoord4.xy * float2( 1,1 ) + float2( 0,0 );
				float flpwmap_custom_switch316 = _Float31;
				float lerpResult99 = lerp( flowmap_intensity311 , texCoord100.y , flpwmap_custom_switch316);
				float2 lerpResult283 = lerp( ( maintexUV161 + ( noise70 * noise_intensity_main67 ) ) , flowmap285 , lerpResult99);
				float cos377 = cos( ( _Float39 * PI ) );
				float sin377 = sin( ( _Float39 * PI ) );
				float2 rotator377 = mul( lerpResult283 - float2( 0.5,0.5 ) , float2x2( cos377 , -sin377 , sin377 , cos377 )) + float2( 0.5,0.5 );
				float2 break632 = rotator377;
				float clampResult633 = clamp( break632.x , 0.0 , 1.0 );
				float clampResult634 = clamp( break632.y , 0.0 , 1.0 );
				float2 appendResult635 = (float2(clampResult633 , clampResult634));
				#if defined(_KEYWORD8_REPEAT)
				float2 staticSwitch636 = rotator377;
				#elif defined(_KEYWORD8_CLAMP)
				float2 staticSwitch636 = appendResult635;
				#else
				float2 staticSwitch636 = rotator377;
				#endif
				float4 tex2DNode1 = tex2D( _maintex, staticSwitch636 );
				#if defined(_KEYWORD0_A)
				float staticSwitch599 = tex2DNode1.a;
				#elif defined(_KEYWORD0_R)
				float staticSwitch599 = tex2DNode1.r;
				#else
				float staticSwitch599 = tex2DNode1.a;
				#endif
				float lerpResult374 = lerp( staticSwitch599 , ( pow( staticSwitch599 , _Float34 ) * _Float37 ) , _Float36);
				float2 uv_TextureSample0 = IN.ase_texcoord2.xy * _TextureSample0_ST.xy + _TextureSample0_ST.zw;
				float2 CenteredUV15_g43 = ( uv_TextureSample0 - float2( 0.5,0.5 ) );
				float2 break17_g43 = CenteredUV15_g43;
				float2 appendResult23_g43 = (float2(( length( CenteredUV15_g43 ) * 1.0 * 2.0 ) , ( atan2( break17_g43.x , break17_g43.y ) * ( 1.0 / TWO_PI ) * 1.0 )));
				float2 lerpResult568 = lerp( uv_TextureSample0 , appendResult23_g43 , _Float53);
				float cos417 = cos( ( _Float47 * PI ) );
				float sin417 = sin( ( _Float47 * PI ) );
				float2 rotator417 = mul( lerpResult568 - float2( 0.5,0.5 ) , float2x2( cos417 , -sin417 , sin417 , cos417 )) + float2( 0.5,0.5 );
				float dis_direction277 = tex2D( _TextureSample0, rotator417 ).r;
				float2 appendResult501 = (float2(_Vector15.x , _Vector15.y));
				float2 uv_dissolvetex = IN.ase_texcoord2.xy * _dissolvetex_ST.xy + _dissolvetex_ST.zw;
				float2 appendResult505 = (float2(( _Vector14.x - 1.0 ) , ( _Vector14.y - 1.0 )));
				float2 appendResult502 = (float2(_Vector14.z , _Vector14.w));
				float2 CenteredUV15_g10 = ( uv_dissolvetex - float2( 0.5,0.5 ) );
				float2 break17_g10 = CenteredUV15_g10;
				float2 appendResult23_g10 = (float2(( length( CenteredUV15_g10 ) * _Vector14.x * 2.0 ) , ( atan2( break17_g10.x , break17_g10.y ) * ( 1.0 / TWO_PI ) * _Vector14.y )));
				float2 lerpResult511 = lerp( (uv_dissolvetex*appendResult505 + ( uv_dissolvetex + appendResult502 )) , (appendResult23_g10*float2( 1,1 ) + appendResult502) , _Float53);
				float2 panner58 = ( 1.0 * _Time.y * appendResult501 + lerpResult511);
				float noise_intensity_dis678 = ( _Float33 * 0.1 );
				float4 texCoord303 = IN.ase_texcoord4;
				texCoord303.xy = IN.ase_texcoord4.xy * float2( 1,1 ) + float2( 0,0 );
				float lerpResult307 = lerp( flowmap_intensity311 , texCoord303.y , flpwmap_custom_switch316);
				float2 lerpResult309 = lerp( ( panner58 + ( noise70 * noise_intensity_dis678 ) ) , flowmap285 , lerpResult307);
				float2 dissolveUV92 = lerpResult309;
				float cos386 = cos( ( _Float41 * PI ) );
				float sin386 = sin( ( _Float41 * PI ) );
				float2 rotator386 = mul( dissolveUV92 - float2( 0.5,0.5 ) , float2x2( cos386 , -sin386 , sin386 , cos386 )) + float2( 0.5,0.5 );
				float2 break652 = rotator386;
				float clampResult654 = clamp( break652.x , 0.0 , 1.0 );
				float clampResult653 = clamp( break652.y , 0.0 , 1.0 );
				float2 appendResult655 = (float2(clampResult654 , clampResult653));
				#if defined(_KEYWORD12_REPEAT)
				float2 staticSwitch656 = rotator386;
				#elif defined(_KEYWORD12_CLAMP)
				float2 staticSwitch656 = appendResult655;
				#else
				float2 staticSwitch656 = rotator386;
				#endif
				float temp_output_280_0 = ( dis_direction277 * tex2D( _dissolvetex, staticSwitch656 ).r );
				float4 texCoord49 = IN.ase_texcoord4;
				texCoord49.xy = IN.ase_texcoord4.xy * float2( 1,1 ) + float2( 0,0 );
				float lerpResult62 = lerp( _Float6 , ( 1.0 - texCoord49.x ) , _Float11);
				float smoothstepResult32 = smoothstep( ( 1.0 - _Float8 ) , _Float8 , saturate( ( ( temp_output_280_0 + 1.0 ) - ( lerpResult62 * 2.0 ) ) ));
				float dis_soft122 = smoothstepResult32;
				float temp_output_130_0 = (0.0 + (temp_output_280_0 - -0.5) * (1.0 - 0.0) / (1.5 - -0.5));
				float temp_output_105_0 = step( lerpResult62 , temp_output_130_0 );
				float dis_bright124 = temp_output_105_0;
				float lerpResult413 = lerp( dis_soft122 , dis_bright124 , _Float25);
				float4 screenPos97 = IN.ase_texcoord5;
				float4 ase_screenPosNorm97 = screenPos97 / screenPos97.w;
				ase_screenPosNorm97.z = ( UNITY_NEAR_CLIP_VALUE >= 0 ) ? ase_screenPosNorm97.z : ase_screenPosNorm97.z * 0.5 + 0.5;
				float screenDepth97 = LinearEyeDepth(SHADERGRAPH_SAMPLE_SCENE_DEPTH( ase_screenPosNorm97.xy ),_ZBufferParams);
				float distanceDepth97 = saturate( abs( ( screenDepth97 - LinearEyeDepth( ase_screenPosNorm97.z,_ZBufferParams ) ) / ( _Float16 ) ) );
				float depthfade_switch334 = _Float5;
				float lerpResult336 = lerp( distanceDepth97 , ( 1.0 - distanceDepth97 ) , depthfade_switch334);
				float depthfade126 = lerpResult336;
				float lerpResult338 = lerp( depthfade126 , 1.0 , depthfade_switch334);
				float2 appendResult480 = (float2(_Vector11.x , _Vector11.y));
				float2 uv_Mask = IN.ase_texcoord2.xy * _Mask_ST.xy + _Mask_ST.zw;
				float2 appendResult473 = (float2(( _Vector10.x - 1.0 ) , ( _Vector10.y - 1.0 )));
				float2 appendResult481 = (float2(_Vector10.z , _Vector10.w));
				float4 texCoord74 = IN.ase_texcoord3;
				texCoord74.xy = IN.ase_texcoord3.xy * float2( 1,1 ) + float2( 0,0 );
				float2 appendResult75 = (float2(texCoord74.z , texCoord74.w));
				float2 lerpResult474 = lerp( appendResult481 , appendResult75 , _Float12);
				float2 CenteredUV15_g42 = ( uv_Mask - float2( 0.5,0.5 ) );
				float2 break17_g42 = CenteredUV15_g42;
				float2 appendResult23_g42 = (float2(( length( CenteredUV15_g42 ) * _Vector10.x * 2.0 ) , ( atan2( break17_g42.x , break17_g42.y ) * ( 1.0 / TWO_PI ) * _Vector10.y )));
				float2 lerpResult471 = lerp( appendResult481 , appendResult75 , _Float12);
				float2 lerpResult467 = lerp( (uv_Mask*appendResult473 + ( uv_Mask + lerpResult474 )) , (appendResult23_g42*float2( 1,1 ) + lerpResult471) , _Float51);
				float2 panner79 = ( 1.0 * _Time.y * appendResult480 + lerpResult467);
				float noise_intensity_mask675 = ( _Float18 * 0.1 );
				float temp_output_322_0 = ( noise70 * noise_intensity_mask675 );
				float cos392 = cos( ( _Float43 * PI ) );
				float sin392 = sin( ( _Float43 * PI ) );
				float2 rotator392 = mul( ( panner79 + temp_output_322_0 ) - float2( 0.5,0.5 ) , float2x2( cos392 , -sin392 , sin392 , cos392 )) + float2( 0.5,0.5 );
				float2 break642 = rotator392;
				float clampResult644 = clamp( break642.x , 0.0 , 1.0 );
				float clampResult643 = clamp( break642.y , 0.0 , 1.0 );
				float2 appendResult645 = (float2(clampResult644 , clampResult643));
				#if defined(_KEYWORD10_REPEAT)
				float2 staticSwitch646 = rotator392;
				#elif defined(_KEYWORD10_CLAMP)
				float2 staticSwitch646 = appendResult645;
				#else
				float2 staticSwitch646 = rotator392;
				#endif
				float4 tex2DNode8 = tex2D( _Mask, staticSwitch646 );
				#if defined(_KEYWORD4_A)
				float staticSwitch606 = tex2DNode8.a;
				#elif defined(_KEYWORD4_R)
				float staticSwitch606 = tex2DNode8.r;
				#else
				float staticSwitch606 = tex2DNode8.a;
				#endif
				float2 appendResult485 = (float2(_Vector13.x , _Vector13.y));
				float2 uv_Mask1 = IN.ase_texcoord2.xy * _Mask1_ST.xy + _Mask1_ST.zw;
				float2 appendResult489 = (float2(( _Vector12.x - 1.0 ) , ( _Vector12.y - 1.0 )));
				float2 appendResult486 = (float2(_Vector12.z , _Vector12.w));
				float2 CenteredUV15_g41 = ( uv_Mask1 - float2( 0.5,0.5 ) );
				float2 break17_g41 = CenteredUV15_g41;
				float2 appendResult23_g41 = (float2(( length( CenteredUV15_g41 ) * _Vector12.x * 2.0 ) , ( atan2( break17_g41.x , break17_g41.y ) * ( 1.0 / TWO_PI ) * _Vector12.y )));
				float2 lerpResult495 = lerp( (uv_Mask1*appendResult489 + ( uv_Mask1 + appendResult486 )) , (appendResult23_g41*float2( 1,1 ) + appendResult486) , _Float52);
				float2 panner216 = ( 1.0 * _Time.y * appendResult485 + lerpResult495);
				float cos389 = cos( ( _Float42 * PI ) );
				float sin389 = sin( ( _Float42 * PI ) );
				float2 rotator389 = mul( ( temp_output_322_0 + panner216 ) - float2( 0.5,0.5 ) , float2x2( cos389 , -sin389 , sin389 , cos389 )) + float2( 0.5,0.5 );
				float2 break647 = rotator389;
				float clampResult649 = clamp( break647.x , 0.0 , 1.0 );
				float clampResult648 = clamp( break647.y , 0.0 , 1.0 );
				float2 appendResult650 = (float2(clampResult649 , clampResult648));
				#if defined(_KEYWORD11_REPEAT)
				float2 staticSwitch651 = rotator389;
				#elif defined(_KEYWORD11_CLAMP)
				float2 staticSwitch651 = appendResult650;
				#else
				float2 staticSwitch651 = rotator389;
				#endif
				float4 tex2DNode218 = tex2D( _Mask1, staticSwitch651 );
				#if defined(_KEYWORD6_A)
				float staticSwitch608 = tex2DNode218.a;
				#elif defined(_KEYWORD6_R)
				float staticSwitch608 = tex2DNode218.r;
				#else
				float staticSwitch608 = tex2DNode218.a;
				#endif
				float Mask82 = ( staticSwitch606 * staticSwitch608 );
				float3 ase_worldViewDir = ( _WorldSpaceCameraPos.xyz - WorldPosition );
				ase_worldViewDir = SafeNormalize( ase_worldViewDir );
				float3 ase_worldNormal = IN.ase_texcoord6.xyz;
				float3 normalizedWorldNormal = normalize( ase_worldNormal );
				float fresnelNdotV139 = dot( normalize( ( normalizedWorldNormal * ase_vface ) ), ase_worldViewDir );
				float fresnelNode139 = ( 0.0 + _power3 * pow( max( 1.0 - fresnelNdotV139 , 0.0001 ), _Float19 ) );
				float temp_output_140_0 = saturate( fresnelNode139 );
				float lerpResult144 = lerp( temp_output_140_0 , ( 1.0 - temp_output_140_0 ) , _Float20);
				float fresnel147 = lerpResult144;
				#if defined(_KEYWORD5_OFF)
				float staticSwitch615 = 1.0;
				#elif defined(_KEYWORD5_ON)
				float staticSwitch615 = fresnel147;
				#else
				float staticSwitch615 = 1.0;
				#endif
				float temp_output_6_0 = ( lerpResult374 * IN.ase_color.a * _Color0.a * lerpResult413 * _Float15 * lerpResult338 * Mask82 * staticSwitch615 );
				float clampResult616 = clamp( temp_output_6_0 , 0.0 , 1.0 );
				#if defined(_KEYWORD7_OFF)
				float staticSwitch617 = temp_output_6_0;
				#elif defined(_KEYWORD7_ON)
				float staticSwitch617 = clampResult616;
				#else
				float staticSwitch617 = temp_output_6_0;
				#endif
				
				float Alpha = staticSwitch617;
				float AlphaClipThreshold = 0.5;

				#ifdef _ALPHATEST_ON
					clip(Alpha - AlphaClipThreshold);
				#endif

				#ifdef LOD_FADE_CROSSFADE
					LODDitheringTransition( IN.clipPos.xyz, unity_LODFade.x );
				#endif
				return 0;
			}
			ENDHLSL
		}

	
	}
	
	CustomEditor "UnityEditor.ShaderGraph.PBRMasterGUI"
	Fallback "Hidden/InternalErrorShader"
	
}
/*ASEBEGIN
Version=18935
48;313;1599;706;3930.861;24.31174;1;True;True
Node;AmplifyShaderEditor.CommentaryNode;541;-6988.524,-2462.406;Inherit;False;2957.076;935.458;Comment;44;528;531;51;533;532;536;535;534;538;537;540;529;539;393;530;53;394;395;55;50;360;67;70;559;560;561;562;564;573;574;567;663;664;665;666;667;674;675;676;677;678;679;682;683;扰动;1,1,1,1;0;0
Node;AmplifyShaderEditor.Vector4Node;528;-6982.423,-1904.828;Inherit;False;Property;_Vector16;扰动_tilling&offset;75;0;Create;False;0;0;0;False;0;False;1,1,0,0;1,1,0,0;0;5;FLOAT4;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.DynamicAppendNode;531;-6546.552,-1769.548;Inherit;False;FLOAT2;4;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;0;False;3;FLOAT;0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.TextureCoordinatesNode;51;-6953.58,-2106.541;Inherit;False;0;50;2;3;2;SAMPLER2D;;False;0;FLOAT2;1,1;False;1;FLOAT2;0,0;False;5;FLOAT2;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.SimpleSubtractOpNode;533;-6546.364,-1949.837;Inherit;False;2;0;FLOAT;0;False;1;FLOAT;1;False;1;FLOAT;0
Node;AmplifyShaderEditor.SimpleSubtractOpNode;532;-6542.503,-1856.848;Inherit;False;2;0;FLOAT;0;False;1;FLOAT;1;False;1;FLOAT;0
Node;AmplifyShaderEditor.FunctionNode;535;-6375.861,-2074.593;Inherit;False;Polar Coordinates;-1;;6;7dab8e02884cf104ebefaa2e788e4162;0;4;1;FLOAT2;0,0;False;2;FLOAT2;0.5,0.5;False;3;FLOAT;1;False;4;FLOAT;1;False;1;FLOAT2;0
Node;AmplifyShaderEditor.DynamicAppendNode;534;-6370.616,-1854.036;Inherit;False;FLOAT2;4;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;0;False;3;FLOAT;0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.SimpleAddOpNode;536;-6194.831,-1913.111;Inherit;False;2;2;0;FLOAT2;0,0;False;1;FLOAT2;0,0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.ScaleAndOffsetNode;538;-6001.633,-2060.579;Inherit;False;3;0;FLOAT2;0,0;False;1;FLOAT2;1,1;False;2;FLOAT2;0,0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.RangedFloatNode;540;-6097.051,-1653.278;Inherit;False;Property;_Float54;扰动极坐标开关;74;1;[Toggle];Create;False;0;0;0;False;0;False;0;0;0;0;0;1;FLOAT;0
Node;AmplifyShaderEditor.Vector4Node;529;-6920.552,-1738.948;Inherit;False;Property;_Vector17;扰动流动速度;76;0;Create;False;0;0;0;False;0;False;0,0,0,0;0,0,0,0;0;5;FLOAT4;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.ScaleAndOffsetNode;537;-5973.886,-1835.885;Inherit;False;3;0;FLOAT2;0,0;False;1;FLOAT2;0,0;False;2;FLOAT2;0,0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.LerpOp;539;-5675.731,-2035.032;Inherit;False;3;0;FLOAT2;0,0;False;1;FLOAT2;0,0;False;2;FLOAT;0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.RangedFloatNode;393;-5734.095,-1864.288;Inherit;False;Property;_Float44;扰动贴图旋转;71;0;Create;False;0;0;0;False;0;False;0;0;-1;1;0;1;FLOAT;0
Node;AmplifyShaderEditor.DynamicAppendNode;530;-6530.552,-1677.948;Inherit;False;FLOAT2;4;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;0;False;3;FLOAT;0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.PiNode;394;-5375.165,-1859.963;Inherit;False;1;0;FLOAT;1;False;1;FLOAT;0
Node;AmplifyShaderEditor.PannerNode;53;-5369.967,-2047.232;Inherit;False;3;0;FLOAT2;0,0;False;2;FLOAT2;0,0;False;1;FLOAT;1;False;1;FLOAT2;0
Node;AmplifyShaderEditor.RotatorNode;395;-5156.717,-2040.766;Inherit;False;3;0;FLOAT2;0,0;False;1;FLOAT2;0.5,0.5;False;2;FLOAT;1;False;1;FLOAT2;0
Node;AmplifyShaderEditor.BreakToComponentsNode;663;-5567.716,-1736.424;Inherit;False;FLOAT2;1;0;FLOAT2;0,0;False;16;FLOAT;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4;FLOAT;5;FLOAT;6;FLOAT;7;FLOAT;8;FLOAT;9;FLOAT;10;FLOAT;11;FLOAT;12;FLOAT;13;FLOAT;14;FLOAT;15
Node;AmplifyShaderEditor.TextureCoordinatesNode;561;-5978.11,-2384.321;Inherit;False;0;564;2;3;2;SAMPLER2D;;False;0;FLOAT2;1,1;False;1;FLOAT2;0,0;False;5;FLOAT2;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.ClampOpNode;665;-5344.579,-1642.547;Inherit;False;3;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;1;False;1;FLOAT;0
Node;AmplifyShaderEditor.RangedFloatNode;559;-5710.384,-2172.668;Inherit;False;Property;_Float57;扰动遮罩旋转;73;0;Create;False;0;0;0;False;0;False;0;0;-1;1;0;1;FLOAT;0
Node;AmplifyShaderEditor.ClampOpNode;664;-5340.444,-1760.551;Inherit;False;3;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;1;False;1;FLOAT;0
Node;AmplifyShaderEditor.FunctionNode;573;-5484.693,-2329.127;Inherit;False;Polar Coordinates;-1;;9;7dab8e02884cf104ebefaa2e788e4162;0;4;1;FLOAT2;0,0;False;2;FLOAT2;0.5,0.5;False;3;FLOAT;1;False;4;FLOAT;1;False;1;FLOAT2;0
Node;AmplifyShaderEditor.LerpOp;574;-5062.254,-2418.959;Inherit;False;3;0;FLOAT2;0,0;False;1;FLOAT2;0,0;False;2;FLOAT;0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.DynamicAppendNode;666;-5102.737,-1685.199;Inherit;False;FLOAT2;4;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;0;False;3;FLOAT;0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.PiNode;560;-5282.872,-2250.677;Inherit;False;1;0;FLOAT;1;False;1;FLOAT;0
Node;AmplifyShaderEditor.StaticSwitch;667;-4993.728,-1929.425;Inherit;False;Property;_Keyword14;扰动UV;70;0;Create;False;0;0;0;False;0;False;0;0;0;True;;KeywordEnum;2;Repeat;Clamp;Create;True;True;All;9;1;FLOAT2;0,0;False;0;FLOAT2;0,0;False;2;FLOAT2;0,0;False;3;FLOAT2;0,0;False;4;FLOAT2;0,0;False;5;FLOAT2;0,0;False;6;FLOAT2;0,0;False;7;FLOAT2;0,0;False;8;FLOAT2;0,0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.RotatorNode;562;-4882.833,-2392.176;Inherit;False;3;0;FLOAT2;0,0;False;1;FLOAT2;0.5,0.5;False;2;FLOAT;1;False;1;FLOAT2;0
Node;AmplifyShaderEditor.CommentaryNode;512;-7152.09,-201.3295;Inherit;False;2803.434;1805.293;Comment;26;499;504;503;502;57;505;506;509;510;507;508;500;511;501;58;92;314;317;302;304;306;307;309;303;681;680;溶解uv;1,1,1,1;0;0
Node;AmplifyShaderEditor.SamplerNode;564;-4716.289,-2381.542;Inherit;True;Property;_TextureSample1;扰动遮罩;72;1;[NoScaleOffset];Create;False;0;0;0;False;0;False;-1;None;None;True;0;False;white;Auto;False;Object;-1;Auto;Texture1D;8;0;SAMPLER1D;;False;1;FLOAT;0;False;2;FLOAT;0;False;3;FLOAT;0;False;4;FLOAT;0;False;5;FLOAT;1;False;6;FLOAT;0;False;7;SAMPLERSTATE;;False;5;COLOR;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.SamplerNode;50;-4763.171,-2114.146;Inherit;True;Property;_noise;扰动贴图;69;1;[NoScaleOffset];Create;False;0;0;0;False;2;Header(___________________________________________________________________________________________________________________________________________________________________________________________________________________________________________);Header(Noise);False;-1;None;None;True;0;False;white;Auto;False;Object;-1;Auto;Texture2D;8;0;SAMPLER2D;;False;1;FLOAT2;0,0;False;2;FLOAT;0;False;3;FLOAT2;0,0;False;4;FLOAT2;0,0;False;5;FLOAT;1;False;6;FLOAT;0;False;7;SAMPLERSTATE;;False;5;COLOR;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.Vector4Node;499;-7047.366,240.7938;Inherit;False;Property;_Vector14;溶解_tilling&offset;62;0;Create;False;0;0;0;False;0;False;1,1,0,0;2,3,0,0;0;5;FLOAT4;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.SimpleMultiplyOpNode;567;-4373.875,-2230.826;Inherit;False;2;2;0;FLOAT;0;False;1;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.DynamicAppendNode;502;-6612.197,436.1238;Inherit;False;FLOAT2;4;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;0;False;3;FLOAT;0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.SimpleSubtractOpNode;504;-6613.727,232.6517;Inherit;False;2;0;FLOAT;0;False;1;FLOAT;1;False;1;FLOAT;0
Node;AmplifyShaderEditor.SimpleAddOpNode;682;-4399.242,-2043.54;Inherit;False;2;2;0;FLOAT;0;False;1;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.TextureCoordinatesNode;57;-7102.09,-121.6233;Inherit;False;0;23;2;3;2;SAMPLER2D;;False;0;FLOAT2;1,1;False;1;FLOAT2;0,0;False;5;FLOAT2;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.RangedFloatNode;679;-4782.816,-1619.502;Inherit;False;Property;_Float33;溶解扰动强度;80;0;Create;False;0;0;0;False;0;False;0;0;0;0;0;1;FLOAT;0
Node;AmplifyShaderEditor.SimpleSubtractOpNode;503;-6613.945,341.5447;Inherit;False;2;0;FLOAT;0;False;1;FLOAT;1;False;1;FLOAT;0
Node;AmplifyShaderEditor.SimpleAddOpNode;509;-6199.673,286.8118;Inherit;False;2;2;0;FLOAT2;0,0;False;1;FLOAT2;0,0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.CommentaryNode;312;-5354.623,-2921.351;Inherit;False;1094.708;330.5801;flowmap;7;241;242;285;310;311;305;316;flowmap;1,1,1,1;0;0
Node;AmplifyShaderEditor.DynamicAppendNode;505;-6409.918,213.2968;Inherit;False;FLOAT2;4;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;0;False;3;FLOAT;0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.FunctionNode;506;-6345.101,-151.3293;Inherit;False;Polar Coordinates;-1;;10;7dab8e02884cf104ebefaa2e788e4162;0;4;1;FLOAT2;0,0;False;2;FLOAT2;0.5,0.5;False;3;FLOAT;1;False;4;FLOAT;1;False;1;FLOAT2;0
Node;AmplifyShaderEditor.StaticSwitch;683;-4195.872,-2162.172;Inherit;False;Property;doublenoise;双重扰动;77;0;Create;False;0;0;0;True;0;False;0;0;0;True;;KeywordEnum;2;off;on;Create;True;True;All;9;1;FLOAT;0;False;0;FLOAT;0;False;2;FLOAT;0;False;3;FLOAT;0;False;4;FLOAT;0;False;5;FLOAT;0;False;6;FLOAT;0;False;7;FLOAT;0;False;8;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.SimpleMultiplyOpNode;677;-4610.922,-1619.117;Inherit;False;2;2;0;FLOAT;0;False;1;FLOAT;0.1;False;1;FLOAT;0
Node;AmplifyShaderEditor.CommentaryNode;450;-3187.231,-5015.317;Inherit;False;1909.787;1280.942;Comment;21;431;39;60;42;433;434;59;435;35;43;443;436;449;439;446;430;440;36;161;609;610;Maintex;1,1,1,1;0;0
Node;AmplifyShaderEditor.TextureCoordinatesNode;39;-3137.231,-4036.375;Inherit;True;1;-1;4;3;2;SAMPLER2D;;False;0;FLOAT2;1,1;False;1;FLOAT2;0,0;False;5;FLOAT4;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.RangedFloatNode;310;-4762.793,-2679.059;Inherit;False;Property;_Float32;flowmap扰动;82;0;Create;False;0;0;0;False;0;False;0;0;0;1;0;1;FLOAT;0
Node;AmplifyShaderEditor.SamplerNode;241;-5304.623,-2866.127;Inherit;True;Property;_flowmaptex;flowmaptex;81;0;Create;True;0;0;0;False;1;Space(20);False;-1;None;None;True;0;False;white;Auto;False;Object;-1;Auto;Texture2D;8;0;SAMPLER2D;;False;1;FLOAT2;0,0;False;2;FLOAT;0;False;3;FLOAT2;0,0;False;4;FLOAT2;0,0;False;5;FLOAT;1;False;6;FLOAT;0;False;7;SAMPLERSTATE;;False;5;COLOR;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.ScaleAndOffsetNode;508;-6018.754,141.8907;Inherit;False;3;0;FLOAT2;0,0;False;1;FLOAT2;0,0;False;2;FLOAT2;0,0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.RegisterLocalVarNode;70;-4236.183,-1979.59;Inherit;False;noise;-1;True;1;0;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.Vector4Node;431;-3146.403,-4457.185;Inherit;False;Property;_Vector8;主贴图tilling&offset;30;0;Create;False;0;0;0;False;0;False;1,1,0,0;1,1,0,0;0;5;FLOAT4;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.RangedFloatNode;305;-4756.977,-2785.977;Inherit;False;Property;_Float31;custom2y控制flowmap扭曲;107;1;[Toggle];Create;False;0;0;0;True;0;False;0;0;0;0;0;1;FLOAT;0
Node;AmplifyShaderEditor.ScaleAndOffsetNode;507;-5988.843,-94.87536;Inherit;False;3;0;FLOAT2;0,0;False;1;FLOAT2;1,1;False;2;FLOAT2;0,0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.RangedFloatNode;510;-6130.35,518.7317;Inherit;False;Property;_Float53;溶解极坐标开关;61;1;[Toggle];Create;False;0;0;0;False;0;False;0;0;0;0;0;1;FLOAT;0
Node;AmplifyShaderEditor.RegisterLocalVarNode;678;-4400.399,-1614.05;Inherit;False;noise_intensity_dis;-1;True;1;0;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.Vector4Node;500;-6974.025,551.1287;Inherit;False;Property;_Vector15;溶解流动速度;63;0;Create;False;0;0;0;False;0;False;0,0,0,0;0,0,0,0;0;5;FLOAT4;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.GetLocalVarNode;302;-5891.683,903.8477;Inherit;False;678;noise_intensity_dis;1;0;OBJECT;;False;1;FLOAT;0
Node;AmplifyShaderEditor.RangedFloatNode;60;-2561.163,-3970.3;Inherit;False;Property;_Float10;custom1xy控制主贴图偏移;104;1;[Toggle];Create;False;0;0;0;True;2;Header(___________________________________________________________________________________________________________________________________________________________________________________________________________________________________________);Header(Custom);False;0;0;0;0;0;1;FLOAT;0
Node;AmplifyShaderEditor.RegisterLocalVarNode;316;-4487.092,-2787.989;Inherit;False;flpwmap_custom_switch;-1;True;1;0;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.DynamicAppendNode;242;-4990.349,-2844.771;Inherit;True;FLOAT2;4;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;0;False;3;FLOAT;0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.DynamicAppendNode;501;-6574.025,583.1287;Inherit;False;FLOAT2;4;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;0;False;3;FLOAT;0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.LerpOp;511;-5701.185,88.00779;Inherit;False;3;0;FLOAT2;0,0;False;1;FLOAT2;0,0;False;2;FLOAT;0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.GetLocalVarNode;304;-5845.153,765.3596;Inherit;False;70;noise;1;0;OBJECT;;False;1;FLOAT;0
Node;AmplifyShaderEditor.DynamicAppendNode;433;-2777.572,-4317.2;Inherit;False;FLOAT2;4;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;0;False;3;FLOAT;0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.DynamicAppendNode;42;-2798.678,-4025.169;Inherit;True;FLOAT2;4;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;0;False;3;FLOAT;0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.RegisterLocalVarNode;311;-4470.831,-2673.398;Inherit;False;flowmap_intensity;-1;True;1;0;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.PannerNode;58;-5354.796,116.1688;Inherit;False;3;0;FLOAT2;0,0;False;2;FLOAT2;0,0;False;1;FLOAT;1;False;1;FLOAT2;0
Node;AmplifyShaderEditor.SimpleMultiplyOpNode;680;-5562.581,729.9785;Inherit;False;2;2;0;FLOAT;0;False;1;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.SimpleSubtractOpNode;434;-2771.599,-4508.884;Inherit;False;2;0;FLOAT;0;False;1;FLOAT;1;False;1;FLOAT;0
Node;AmplifyShaderEditor.GetLocalVarNode;314;-5738.604,1173.878;Inherit;False;311;flowmap_intensity;1;0;OBJECT;;False;1;FLOAT;0
Node;AmplifyShaderEditor.TextureCoordinatesNode;35;-3161.751,-4971.501;Inherit;False;0;1;2;3;2;SAMPLER2D;;False;0;FLOAT2;1,1;False;1;FLOAT2;0,0;False;5;FLOAT2;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.TextureCoordinatesNode;303;-6130.361,1301.963;Inherit;True;2;-1;4;3;2;SAMPLER2D;;False;0;FLOAT2;1,1;False;1;FLOAT2;0,0;False;5;FLOAT4;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.SimpleSubtractOpNode;435;-2783.797,-4416.758;Inherit;False;2;0;FLOAT;0;False;1;FLOAT;1;False;1;FLOAT;0
Node;AmplifyShaderEditor.LerpOp;59;-2543.709,-4330.816;Inherit;False;3;0;FLOAT2;0,0;False;1;FLOAT2;0,0;False;2;FLOAT;0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.GetLocalVarNode;317;-5544.523,1321.365;Inherit;False;316;flpwmap_custom_switch;1;0;OBJECT;;False;1;FLOAT;0
Node;AmplifyShaderEditor.CommentaryNode;498;-7011.592,-5547.575;Inherit;False;3316.701;2494.345;Comment;62;478;74;73;75;481;483;488;487;486;474;476;475;77;217;477;473;469;471;491;489;497;479;496;470;468;472;321;323;493;484;494;322;485;495;467;480;79;390;216;387;319;388;320;391;392;389;218;8;220;82;606;608;642;643;644;645;646;647;648;649;651;650;Mask;1,1,1,1;0;0
Node;AmplifyShaderEditor.RegisterLocalVarNode;285;-4703.584,-2871.351;Inherit;False;flowmap;-1;True;1;0;FLOAT2;0,0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.Vector4Node;478;-6688,-5072;Inherit;False;Property;_Vector10;Mask01_tilling&offset;47;0;Create;False;0;0;0;False;0;False;1,1,0,0;1,1,0,0;0;5;FLOAT4;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.LerpOp;307;-5101.527,1012.535;Inherit;False;3;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.TextureCoordinatesNode;74;-6707.094,-4562.272;Inherit;True;1;-1;4;3;2;SAMPLER2D;;False;0;FLOAT2;1,1;False;1;FLOAT2;0,0;False;5;FLOAT4;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.GetLocalVarNode;306;-5589.274,985.6667;Inherit;False;285;flowmap;1;0;OBJECT;;False;1;FLOAT2;0
Node;AmplifyShaderEditor.DynamicAppendNode;436;-2581.709,-4506.817;Inherit;False;FLOAT2;4;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;0;False;3;FLOAT;0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.SimpleAddOpNode;681;-5263.581,663.6785;Inherit;False;2;2;0;FLOAT2;0,0;False;1;FLOAT;0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.FunctionNode;443;-2522.946,-4965.317;Inherit;False;Polar Coordinates;-1;;18;7dab8e02884cf104ebefaa2e788e4162;0;4;1;FLOAT2;0,0;False;2;FLOAT2;0.5,0.5;False;3;FLOAT;1;False;4;FLOAT;1;False;1;FLOAT2;0
Node;AmplifyShaderEditor.SimpleAddOpNode;43;-2367.709,-4410.816;Inherit;False;2;2;0;FLOAT2;0,0;False;1;FLOAT2;0,0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.LerpOp;449;-2399.709,-4762.817;Inherit;False;3;0;FLOAT2;0,0;False;1;FLOAT2;0,0;False;2;FLOAT;0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.ScaleAndOffsetNode;430;-2303.709,-4618.817;Inherit;False;3;0;FLOAT2;0,0;False;1;FLOAT2;0,0;False;2;FLOAT2;0,0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.RangedFloatNode;73;-6053.1,-4481.973;Inherit;False;Property;_Float12;custom1zw控制mask01偏移;105;1;[Toggle];Create;False;0;0;0;True;0;False;0;0;0;0;0;1;FLOAT;0
Node;AmplifyShaderEditor.CommentaryNode;657;-3934.213,-1740.459;Inherit;False;2876.65;1092.237;软溶解;27;49;62;61;30;24;26;45;34;32;25;31;33;122;280;23;281;384;385;93;386;29;652;653;655;654;656;714;软溶解;1,1,1,1;0;0
Node;AmplifyShaderEditor.Vector4Node;483;-6944,-3520;Inherit;False;Property;_Vector12;Mask02_tilling&offset;54;0;Create;False;0;0;0;False;0;False;1,1,0,0;1,1,0,0;0;5;FLOAT4;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.RangedFloatNode;610;-2126.682,-4442.735;Inherit;False;Property;_Float50;主贴图极坐标开关;26;1;[Toggle];Create;False;0;0;0;False;0;False;0;0;0;0;0;1;FLOAT;0
Node;AmplifyShaderEditor.Vector4Node;439;-3109.81,-4253.738;Inherit;False;Property;_Vector0;主贴图流动速度;31;0;Create;False;0;0;0;False;0;False;0,0,0,0;0,0,0,0;0;5;FLOAT4;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.DynamicAppendNode;481;-6304,-4848;Inherit;False;FLOAT2;4;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;0;False;3;FLOAT;0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.RangedFloatNode;55;-4772.287,-1833.394;Inherit;False;Property;_Float9;主贴图扰动强度;78;0;Create;False;0;0;0;False;0;False;0;0;0;0;0;1;FLOAT;0
Node;AmplifyShaderEditor.DynamicAppendNode;75;-6387.791,-4521.63;Inherit;True;FLOAT2;4;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;0;False;3;FLOAT;0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.ScaleAndOffsetNode;446;-2122.163,-4942.705;Inherit;False;3;0;FLOAT2;0,0;False;1;FLOAT2;1,1;False;2;FLOAT2;0,0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.LerpOp;309;-5113.266,741.1697;Inherit;False;3;0;FLOAT2;0,0;False;1;FLOAT2;0,0;False;2;FLOAT;0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.LerpOp;474;-6064,-4880;Inherit;False;3;0;FLOAT2;0,0;False;1;FLOAT2;0,0;False;2;FLOAT;0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.LerpOp;609;-1820.086,-4702.983;Inherit;False;3;0;FLOAT2;0,0;False;1;FLOAT2;0,0;False;2;FLOAT;0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.SimpleSubtractOpNode;487;-6550.868,-3458.229;Inherit;False;2;0;FLOAT;0;False;1;FLOAT;1;False;1;FLOAT;0
Node;AmplifyShaderEditor.CommentaryNode;278;-3229.496,771.2501;Inherit;False;2403.086;1048.659;溶解方向;8;277;412;415;416;417;418;568;571;溶解方向;1,1,1,1;0;0
Node;AmplifyShaderEditor.DynamicAppendNode;486;-6540,-3344.619;Inherit;False;FLOAT2;4;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;0;False;3;FLOAT;0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.SimpleSubtractOpNode;475;-6304,-4944;Inherit;False;2;0;FLOAT;0;False;1;FLOAT;1;False;1;FLOAT;0
Node;AmplifyShaderEditor.TextureCoordinatesNode;217;-6961.592,-3882.391;Inherit;False;0;218;2;3;2;SAMPLER2D;;False;0;FLOAT2;1,1;False;1;FLOAT2;0,0;False;5;FLOAT2;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.SimpleSubtractOpNode;476;-6304,-5040;Inherit;False;2;0;FLOAT;0;False;1;FLOAT;1;False;1;FLOAT;0
Node;AmplifyShaderEditor.RegisterLocalVarNode;92;-4600.846,75.22968;Inherit;False;dissolveUV;-1;True;1;0;FLOAT2;0,0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.SimpleSubtractOpNode;488;-6554.917,-3553.153;Inherit;False;2;0;FLOAT;0;False;1;FLOAT;1;False;1;FLOAT;0
Node;AmplifyShaderEditor.TextureCoordinatesNode;77;-6812.215,-5399.461;Inherit;False;0;8;2;3;2;SAMPLER2D;;False;0;FLOAT2;1,1;False;1;FLOAT2;0,0;False;5;FLOAT2;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.SimpleMultiplyOpNode;360;-4600.393,-1833.009;Inherit;False;2;2;0;FLOAT;0;False;1;FLOAT;0.1;False;1;FLOAT;0
Node;AmplifyShaderEditor.RangedFloatNode;676;-4774.56,-1717.209;Inherit;False;Property;_Float18;mask扰动强度;79;0;Create;False;0;0;0;False;0;False;0;0;0;0;0;1;FLOAT;0
Node;AmplifyShaderEditor.DynamicAppendNode;440;-2784.515,-4202.459;Inherit;False;FLOAT2;4;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;0;False;3;FLOAT;0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.RangedFloatNode;384;-3883.271,-1398.666;Inherit;False;Property;_Float41;溶解贴图旋转;58;0;Create;False;0;0;0;False;0;False;0;0;-1;1;0;1;FLOAT;0
Node;AmplifyShaderEditor.DynamicAppendNode;489;-6362.194,-3585.178;Inherit;False;FLOAT2;4;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;0;False;3;FLOAT;0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.FunctionNode;477;-6049.21,-5497.575;Inherit;False;Polar Coordinates;-1;;42;7dab8e02884cf104ebefaa2e788e4162;0;4;1;FLOAT2;0,0;False;2;FLOAT2;0.5,0.5;False;3;FLOAT;1;False;4;FLOAT;1;False;1;FLOAT2;0
Node;AmplifyShaderEditor.SimpleAddOpNode;469;-5888,-4944;Inherit;False;2;2;0;FLOAT2;0,0;False;1;FLOAT2;0,0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.PiNode;385;-3713.449,-1390.31;Inherit;False;1;0;FLOAT;1;False;1;FLOAT;0
Node;AmplifyShaderEditor.DynamicAppendNode;473;-6128,-5040;Inherit;False;FLOAT2;4;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;0;False;3;FLOAT;0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.SimpleMultiplyOpNode;674;-4602.666,-1716.824;Inherit;False;2;2;0;FLOAT;0;False;1;FLOAT;0.1;False;1;FLOAT;0
Node;AmplifyShaderEditor.GetLocalVarNode;93;-3884.213,-1541.452;Inherit;False;92;dissolveUV;1;0;OBJECT;;False;1;FLOAT2;0
Node;AmplifyShaderEditor.LerpOp;471;-5925.974,-5295.075;Inherit;False;3;0;FLOAT2;0,0;False;1;FLOAT2;0,0;False;2;FLOAT;0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.FunctionNode;497;-6297.377,-3949.805;Inherit;False;Polar Coordinates;-1;;41;7dab8e02884cf104ebefaa2e788e4162;0;4;1;FLOAT2;0,0;False;2;FLOAT2;0.5,0.5;False;3;FLOAT;1;False;4;FLOAT;1;False;1;FLOAT2;0
Node;AmplifyShaderEditor.PannerNode;36;-1755.822,-4401.503;Inherit;False;3;0;FLOAT2;0,0;False;2;FLOAT2;0,0;False;1;FLOAT;1;False;1;FLOAT2;0
Node;AmplifyShaderEditor.SimpleAddOpNode;491;-6151.949,-3511.663;Inherit;False;2;2;0;FLOAT2;0,0;False;1;FLOAT2;0,0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.TextureCoordinatesNode;418;-3140.743,970.9597;Inherit;False;0;412;2;3;2;SAMPLER2D;;False;0;FLOAT2;1,1;False;1;FLOAT2;0,0;False;5;FLOAT2;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.RegisterLocalVarNode;67;-4389.87,-1827.942;Inherit;False;noise_intensity_main;-1;True;1;0;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.RegisterLocalVarNode;675;-4392.143,-1711.757;Inherit;False;noise_intensity_mask;-1;True;1;0;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.ScaleAndOffsetNode;472;-5685.974,-5455.075;Inherit;False;3;0;FLOAT2;0,0;False;1;FLOAT2;1,1;False;2;FLOAT2;0,0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.GetLocalVarNode;71;-984.5851,-2468.739;Inherit;False;70;noise;1;0;OBJECT;;False;1;FLOAT;0
Node;AmplifyShaderEditor.ScaleAndOffsetNode;470;-5740.863,-5189.354;Inherit;False;3;0;FLOAT2;0,0;False;1;FLOAT2;0,0;False;2;FLOAT2;0,0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.ScaleAndOffsetNode;496;-5934.142,-3907.305;Inherit;False;3;0;FLOAT2;0,0;False;1;FLOAT2;1,1;False;2;FLOAT2;0,0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.RangedFloatNode;468;-5709.996,-4949.717;Inherit;False;Property;_Float51;Mask01极坐标开关;46;1;[Toggle];Create;False;0;0;0;False;0;False;0;0;0;0;0;1;FLOAT;0
Node;AmplifyShaderEditor.Vector4Node;484;-6928,-3280;Inherit;False;Property;_Vector13;Mask02流动速度;55;0;Create;False;0;0;0;False;0;False;0,0,0,0;0,0,0,0;0;5;FLOAT4;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.GetLocalVarNode;72;-1002.232,-2264.264;Inherit;False;67;noise_intensity_main;1;0;OBJECT;;False;1;FLOAT;0
Node;AmplifyShaderEditor.RotatorNode;386;-3529.313,-1480.235;Inherit;False;3;0;FLOAT2;0,0;False;1;FLOAT2;0.5,0.5;False;2;FLOAT;1;False;1;FLOAT2;0
Node;AmplifyShaderEditor.FunctionNode;571;-2783.199,858.1072;Inherit;False;Polar Coordinates;-1;;43;7dab8e02884cf104ebefaa2e788e4162;0;4;1;FLOAT2;0,0;False;2;FLOAT2;0.5,0.5;False;3;FLOAT;1;False;4;FLOAT;1;False;1;FLOAT2;0
Node;AmplifyShaderEditor.RangedFloatNode;494;-5997.62,-3316.04;Inherit;False;Property;_Float52;Mask02极坐标开关;53;1;[Toggle];Create;False;0;0;0;False;0;False;0;0;0;0;0;1;FLOAT;0
Node;AmplifyShaderEditor.ScaleAndOffsetNode;493;-5971.03,-3656.584;Inherit;False;3;0;FLOAT2;0,0;False;1;FLOAT2;0,0;False;2;FLOAT2;0,0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.RangedFloatNode;415;-2895.178,1495.625;Inherit;False;Property;_Float47;溶解方向旋转;60;0;Create;False;0;0;0;False;0;False;0;0;-1;1;0;1;FLOAT;0
Node;AmplifyShaderEditor.Vector4Node;479;-6672,-4832;Inherit;False;Property;_Vector11;Mask01流动速度;48;0;Create;False;0;0;0;False;0;False;0,0,0,0;0,0,0,0;0;5;FLOAT4;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.RegisterLocalVarNode;161;-1501.439,-4319.998;Inherit;False;maintexUV;-1;True;1;0;FLOAT2;0,0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.DynamicAppendNode;485;-6531.846,-3217.787;Inherit;False;FLOAT2;4;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;0;False;3;FLOAT;0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.GetLocalVarNode;313;-718.4958,-2115.585;Inherit;False;311;flowmap_intensity;1;0;OBJECT;;False;1;FLOAT;0
Node;AmplifyShaderEditor.CommentaryNode;708;-7590.664,2073.03;Inherit;False;3215.285;2191.066;Comment;56;684;544;173;686;687;688;548;546;685;547;690;550;691;551;689;549;554;552;692;555;695;694;693;553;396;698;557;696;697;556;168;700;397;699;398;701;702;658;703;659;704;660;661;705;662;178;167;179;706;175;707;169;172;176;171;181;顶点偏移;1,1,1,1;0;0
Node;AmplifyShaderEditor.LerpOp;467;-5403.192,-5152.456;Inherit;False;3;0;FLOAT2;0,0;False;1;FLOAT2;0,0;False;2;FLOAT;0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.GetLocalVarNode;318;-682.1349,-1977.554;Inherit;False;316;flpwmap_custom_switch;1;0;OBJECT;;False;1;FLOAT;0
Node;AmplifyShaderEditor.BreakToComponentsNode;652;-3300.672,-1416.223;Inherit;False;FLOAT2;1;0;FLOAT2;0,0;False;16;FLOAT;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4;FLOAT;5;FLOAT;6;FLOAT;7;FLOAT;8;FLOAT;9;FLOAT;10;FLOAT;11;FLOAT;12;FLOAT;13;FLOAT;14;FLOAT;15
Node;AmplifyShaderEditor.DynamicAppendNode;480;-6304,-4736;Inherit;False;FLOAT2;4;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;0;False;3;FLOAT;0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.GetLocalVarNode;162;-922.9459,-2597.991;Inherit;False;161;maintexUV;1;0;OBJECT;;False;1;FLOAT2;0
Node;AmplifyShaderEditor.SimpleMultiplyOpNode;353;-832.2198,-2384.883;Inherit;False;2;2;0;FLOAT;0;False;1;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.GetLocalVarNode;323;-5687.571,-3836.099;Inherit;False;675;noise_intensity_mask;1;0;OBJECT;;False;1;FLOAT;0
Node;AmplifyShaderEditor.GetLocalVarNode;321;-5663.11,-3978.392;Inherit;False;70;noise;1;0;OBJECT;;False;1;FLOAT;0
Node;AmplifyShaderEditor.LerpOp;495;-5651.359,-3604.686;Inherit;False;3;0;FLOAT2;0,0;False;1;FLOAT2;0,0;False;2;FLOAT;0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.TextureCoordinatesNode;100;-963.4091,-2036.557;Inherit;False;2;-1;4;3;2;SAMPLER2D;;False;0;FLOAT2;1,1;False;1;FLOAT2;0,0;False;5;FLOAT4;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.PiNode;416;-2481.635,1519.068;Inherit;False;1;0;FLOAT;1;False;1;FLOAT;0
Node;AmplifyShaderEditor.LerpOp;568;-2345.489,1068.091;Inherit;False;3;0;FLOAT2;0,0;False;1;FLOAT2;0,0;False;2;FLOAT;0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.SimpleAddOpNode;354;-591.3008,-2575.51;Inherit;False;2;2;0;FLOAT2;0,0;False;1;FLOAT;0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.RangedFloatNode;390;-5768.422,-4787.938;Inherit;False;Property;_Float43;遮罩01旋转;45;0;Create;False;0;0;0;False;0;False;0;0;-1;1;0;1;FLOAT;0
Node;AmplifyShaderEditor.GetLocalVarNode;284;-570.2188,-2198.665;Inherit;False;285;flowmap;1;0;OBJECT;;False;1;FLOAT2;0
Node;AmplifyShaderEditor.SimpleMultiplyOpNode;322;-5402.77,-3920.105;Inherit;False;2;2;0;FLOAT;0;False;1;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.RotatorNode;417;-2125.709,1018.199;Inherit;False;3;0;FLOAT2;0,0;False;1;FLOAT2;0.5,0.5;False;2;FLOAT;1;False;1;FLOAT2;0
Node;AmplifyShaderEditor.LerpOp;99;-419.9968,-2099.037;Inherit;False;3;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.RangedFloatNode;380;-905.9528,-2780.836;Inherit;False;Property;_Float39;主贴图旋转;25;0;Create;False;0;0;0;False;0;False;0;0;-1;1;0;1;FLOAT;0
Node;AmplifyShaderEditor.RangedFloatNode;387;-5326.22,-3519.667;Inherit;False;Property;_Float42;遮罩02旋转;52;0;Create;False;0;0;0;False;0;False;0;0;-1;1;0;1;FLOAT;0
Node;AmplifyShaderEditor.ClampOpNode;653;-3077.535,-1322.346;Inherit;False;3;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;1;False;1;FLOAT;0
Node;AmplifyShaderEditor.ClampOpNode;654;-3073.4,-1440.35;Inherit;False;3;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;1;False;1;FLOAT;0
Node;AmplifyShaderEditor.Vector4Node;544;-7350.123,3462.803;Inherit;False;Property;_Vector18;顶点偏移_tilling&offset;87;0;Create;False;0;0;0;False;0;False;1,1,0,0;1,1,0,0;0;5;FLOAT4;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.Vector4Node;684;-7499.67,2459.03;Inherit;False;Property;_Vector22;顶点遮罩_tilling&offset;93;0;Create;False;0;0;0;False;0;False;1,1,0,0;1,1,0,0;0;5;FLOAT4;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.PannerNode;216;-5483.541,-3601.472;Inherit;False;3;0;FLOAT2;0,0;False;2;FLOAT2;0,0;False;1;FLOAT;1;False;1;FLOAT2;0
Node;AmplifyShaderEditor.PannerNode;79;-5145.165,-5074.56;Inherit;False;3;0;FLOAT2;0,0;False;2;FLOAT2;0,0;False;1;FLOAT;1;False;1;FLOAT2;0
Node;AmplifyShaderEditor.PiNode;378;-433.6304,-2740.98;Inherit;False;1;0;FLOAT;1;False;1;FLOAT;0
Node;AmplifyShaderEditor.LerpOp;283;-228.6384,-2358.779;Inherit;False;3;0;FLOAT2;0,0;False;1;FLOAT2;0,0;False;2;FLOAT;0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.TextureCoordinatesNode;173;-7391.116,3171.476;Inherit;False;0;169;2;3;2;SAMPLER2D;;False;0;FLOAT2;1,1;False;1;FLOAT2;0,0;False;5;FLOAT2;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.SimpleAddOpNode;319;-5224.375,-4620.084;Inherit;False;2;2;0;FLOAT2;0,0;False;1;FLOAT;0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.DynamicAppendNode;546;-6934.123,3734.803;Inherit;False;FLOAT2;4;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;0;False;3;FLOAT;0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.SimpleSubtractOpNode;688;-7099.67,2619.03;Inherit;False;2;0;FLOAT;0;False;1;FLOAT;1;False;1;FLOAT;0
Node;AmplifyShaderEditor.PiNode;388;-5123.899,-3533.811;Inherit;False;1;0;FLOAT;1;False;1;FLOAT;0
Node;AmplifyShaderEditor.SimpleAddOpNode;320;-5052.652,-3844.109;Inherit;False;2;2;0;FLOAT;0;False;1;FLOAT2;0,0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.PiNode;391;-5255.752,-4791.429;Inherit;False;1;0;FLOAT;1;False;1;FLOAT;0
Node;AmplifyShaderEditor.SimpleSubtractOpNode;548;-6950.123,3622.803;Inherit;False;2;0;FLOAT;0;False;1;FLOAT;1;False;1;FLOAT;0
Node;AmplifyShaderEditor.DynamicAppendNode;686;-7083.67,2731.03;Inherit;False;FLOAT2;4;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;0;False;3;FLOAT;0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.SimpleSubtractOpNode;547;-6950.123,3526.803;Inherit;False;2;0;FLOAT;0;False;1;FLOAT;1;False;1;FLOAT;0
Node;AmplifyShaderEditor.SimpleSubtractOpNode;687;-7099.67,2523.03;Inherit;False;2;0;FLOAT;0;False;1;FLOAT;1;False;1;FLOAT;0
Node;AmplifyShaderEditor.TextureCoordinatesNode;685;-7540.664,2167.703;Inherit;False;0;169;2;3;2;SAMPLER2D;;False;0;FLOAT2;1,1;False;1;FLOAT2;0,0;False;5;FLOAT2;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.SamplerNode;412;-1849.448,989.955;Inherit;True;Property;_TextureSample0;溶解方向贴图（渐变）;59;1;[NoScaleOffset];Create;False;0;0;0;False;0;False;-1;None;None;True;0;False;white;Auto;False;Object;-1;Auto;Texture2D;8;0;SAMPLER2D;;False;1;FLOAT2;0,0;False;2;FLOAT;0;False;3;FLOAT2;0,0;False;4;FLOAT2;0,0;False;5;FLOAT;1;False;6;FLOAT;0;False;7;SAMPLERSTATE;;False;5;COLOR;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.DynamicAppendNode;655;-2835.693,-1364.998;Inherit;False;FLOAT2;4;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;0;False;3;FLOAT;0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.DynamicAppendNode;550;-6754.377,3490.615;Inherit;False;FLOAT2;4;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;0;False;3;FLOAT;0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.RotatorNode;389;-4870.83,-3654.874;Inherit;False;3;0;FLOAT2;0,0;False;1;FLOAT2;0.5,0.5;False;2;FLOAT;1;False;1;FLOAT2;0
Node;AmplifyShaderEditor.StaticSwitch;656;-2742.19,-1538.581;Inherit;False;Property;_Keyword12;溶解UV;57;0;Create;False;0;0;0;False;0;False;0;0;0;True;;KeywordEnum;2;Repeat;Clamp;Create;True;True;All;9;1;FLOAT2;0,0;False;0;FLOAT2;0,0;False;2;FLOAT2;0,0;False;3;FLOAT2;0,0;False;4;FLOAT2;0,0;False;5;FLOAT2;0,0;False;6;FLOAT2;0,0;False;7;FLOAT2;0,0;False;8;FLOAT2;0,0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.CommentaryNode;146;-3141.72,3013.755;Inherit;False;1475.065;723.4756;菲尼尔;11;135;137;138;139;140;141;142;144;147;136;352;菲尼尔;1,1,1,1;0;0
Node;AmplifyShaderEditor.RotatorNode;392;-5042.633,-4687.353;Inherit;False;3;0;FLOAT2;0,0;False;1;FLOAT2;0.5,0.5;False;2;FLOAT;1;False;1;FLOAT2;0
Node;AmplifyShaderEditor.RegisterLocalVarNode;277;-1050.409,1159.944;Inherit;False;dis_direction;-1;True;1;0;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.SimpleAddOpNode;690;-6693.678,2560.356;Inherit;False;2;2;0;FLOAT2;0,0;False;1;FLOAT2;0,0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.DynamicAppendNode;691;-6903.924,2486.842;Inherit;False;FLOAT2;4;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;0;False;3;FLOAT;0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.FunctionNode;549;-6694.123,3126.803;Inherit;False;Polar Coordinates;-1;;44;7dab8e02884cf104ebefaa2e788e4162;0;4;1;FLOAT2;0,0;False;2;FLOAT2;0.5,0.5;False;3;FLOAT;1;False;4;FLOAT;1;False;1;FLOAT2;0
Node;AmplifyShaderEditor.SimpleAddOpNode;551;-6544.131,3564.129;Inherit;False;2;2;0;FLOAT2;0,0;False;1;FLOAT2;0,0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.RotatorNode;377;-66.65041,-2742.963;Inherit;False;3;0;FLOAT2;0,0;False;1;FLOAT2;0.5,0.5;False;2;FLOAT;1;False;1;FLOAT2;0
Node;AmplifyShaderEditor.TextureCoordinatesNode;49;-3528.034,-1125.648;Inherit;True;2;-1;4;3;2;SAMPLER2D;;False;0;FLOAT2;1,1;False;1;FLOAT2;0,0;False;5;FLOAT4;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.FunctionNode;689;-6843.67,2123.03;Inherit;False;Polar Coordinates;-1;;45;7dab8e02884cf104ebefaa2e788e4162;0;4;1;FLOAT2;0,0;False;2;FLOAT2;0.5,0.5;False;3;FLOAT;1;False;4;FLOAT;1;False;1;FLOAT2;0
Node;AmplifyShaderEditor.FaceVariableNode;352;-3012.43,3187.22;Inherit;False;0;1;FLOAT;0
Node;AmplifyShaderEditor.BreakToComponentsNode;632;220.3742,-2680.208;Inherit;False;FLOAT2;1;0;FLOAT2;0,0;False;16;FLOAT;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4;FLOAT;5;FLOAT;6;FLOAT;7;FLOAT;8;FLOAT;9;FLOAT;10;FLOAT;11;FLOAT;12;FLOAT;13;FLOAT;14;FLOAT;15
Node;AmplifyShaderEditor.ScaleAndOffsetNode;554;-6326.323,3168.488;Inherit;False;3;0;FLOAT2;0,0;False;1;FLOAT2;1,1;False;2;FLOAT2;0,0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.RangedFloatNode;695;-6664.529,2783.638;Inherit;False;Property;_Float62;顶点遮罩极坐标开关;92;1;[Toggle];Create;False;0;0;0;False;0;False;0;0;0;0;0;1;FLOAT;0
Node;AmplifyShaderEditor.ScaleAndOffsetNode;693;-6512.757,2415.435;Inherit;False;3;0;FLOAT2;0,0;False;1;FLOAT2;0,0;False;2;FLOAT2;0,0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.RangedFloatNode;552;-6484.982,3797.411;Inherit;False;Property;_Float56;顶点偏移极坐标开关;86;1;[Toggle];Create;False;0;0;0;False;0;False;0;0;0;0;0;1;FLOAT;0
Node;AmplifyShaderEditor.Vector4Node;694;-7458.03,2795.673;Inherit;False;Property;_Vector23;顶点遮罩流动速度;94;0;Create;False;0;0;0;False;0;False;0,0,0,0;0,0,0,0;0;5;FLOAT4;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.ScaleAndOffsetNode;692;-6475.871,2164.715;Inherit;False;3;0;FLOAT2;0,0;False;1;FLOAT2;1,1;False;2;FLOAT2;0,0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.Vector4Node;555;-7308.483,3799.446;Inherit;False;Property;_Vector19;顶点偏移流动速度;88;0;Create;False;0;0;0;False;0;False;0,0,0,0;0,0,0,0;0;5;FLOAT4;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.WorldNormalVector;136;-3118.165,3057.115;Inherit;False;True;1;0;FLOAT3;0,0,1;False;4;FLOAT3;0;FLOAT;1;FLOAT;2;FLOAT;3
Node;AmplifyShaderEditor.GetLocalVarNode;281;-2522.072,-1690.459;Inherit;False;277;dis_direction;1;0;OBJECT;;False;1;FLOAT;0
Node;AmplifyShaderEditor.BreakToComponentsNode;647;-5076.309,-3384.724;Inherit;False;FLOAT2;1;0;FLOAT2;0,0;False;16;FLOAT;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4;FLOAT;5;FLOAT;6;FLOAT;7;FLOAT;8;FLOAT;9;FLOAT;10;FLOAT;11;FLOAT;12;FLOAT;13;FLOAT;14;FLOAT;15
Node;AmplifyShaderEditor.RangedFloatNode;61;-3202.365,-764.2218;Inherit;False;Property;_Float11;custom2x控制溶解;106;1;[Toggle];Create;False;0;0;0;False;0;False;0;1;0;0;0;1;FLOAT;0
Node;AmplifyShaderEditor.ScaleAndOffsetNode;553;-6363.21,3419.208;Inherit;False;3;0;FLOAT2;0,0;False;1;FLOAT2;0,0;False;2;FLOAT2;0,0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.RangedFloatNode;29;-3877.667,-1266.057;Inherit;False;Property;_Float6;溶解;64;0;Create;False;0;0;0;False;0;False;0;0;0;1;0;1;FLOAT;0
Node;AmplifyShaderEditor.BreakToComponentsNode;642;-5116.598,-4396.766;Inherit;False;FLOAT2;1;0;FLOAT2;0,0;False;16;FLOAT;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4;FLOAT;5;FLOAT;6;FLOAT;7;FLOAT;8;FLOAT;9;FLOAT;10;FLOAT;11;FLOAT;12;FLOAT;13;FLOAT;14;FLOAT;15
Node;AmplifyShaderEditor.OneMinusNode;714;-3244.423,-1068.779;Inherit;False;1;0;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.SamplerNode;23;-2540.85,-1459.233;Inherit;True;Property;_dissolvetex;溶解贴图;56;1;[NoScaleOffset];Create;False;0;0;0;False;2;Header(___________________________________________________________________________________________________________________________________________________________________________________________________________________________________________);Header(Dissolove);False;-1;None;45954f1aea35b934f9a4ba8eec258b6f;True;0;False;white;Auto;False;Object;-1;Auto;Texture2D;8;0;SAMPLER2D;;False;1;FLOAT2;0,0;False;2;FLOAT;0;False;3;FLOAT2;0,0;False;4;FLOAT2;0,0;False;5;FLOAT;1;False;6;FLOAT;0;False;7;SAMPLERSTATE;;False;5;COLOR;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.LerpOp;556;-6047.386,3168.431;Inherit;False;3;0;FLOAT2;0,0;False;1;FLOAT2;0,0;False;2;FLOAT;0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.ClampOpNode;648;-4923.438,-3220.58;Inherit;False;3;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;1;False;1;FLOAT;0
Node;AmplifyShaderEditor.CommentaryNode;166;-5360.597,-1118.886;Inherit;False;1013.145;364.3818; 软粒子;9;126;97;98;96;327;333;334;336;337; 软粒子;1,1,1,1;0;0
Node;AmplifyShaderEditor.DynamicAppendNode;698;-7068.03,2856.672;Inherit;False;FLOAT2;4;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;0;False;3;FLOAT;0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.RangedFloatNode;138;-3076.711,3573.226;Inherit;False;Property;_Float19;菲尼尔范围;14;0;Create;False;0;0;0;False;0;False;1;1;0;0;0;1;FLOAT;0
Node;AmplifyShaderEditor.DynamicAppendNode;557;-6918.483,3860.445;Inherit;False;FLOAT2;4;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;0;False;3;FLOAT;0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.ClampOpNode;634;373.2451,-2516.064;Inherit;False;3;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;1;False;1;FLOAT;0
Node;AmplifyShaderEditor.RangedFloatNode;396;-6404.928,3902.599;Inherit;False;Property;_Float45;顶点贴图旋转;85;0;Create;False;0;0;0;False;0;False;0;0;-1;1;0;1;FLOAT;0
Node;AmplifyShaderEditor.SimpleMultiplyOpNode;351;-2795.43,3144.22;Inherit;False;2;2;0;FLOAT3;0,0,0;False;1;FLOAT;0;False;1;FLOAT3;0
Node;AmplifyShaderEditor.RangedFloatNode;696;-6555.476,2897.826;Inherit;False;Property;_Float48;顶点遮罩旋转;91;0;Create;False;0;0;0;False;0;False;0;0;-1;1;0;1;FLOAT;0
Node;AmplifyShaderEditor.SimpleMultiplyOpNode;280;-2231.257,-1568.024;Inherit;False;2;2;0;FLOAT;0;False;1;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.RangedFloatNode;31;-1955.751,-1108.703;Inherit;False;Constant;_Float7;Float 7;11;0;Create;True;0;0;0;False;0;False;2;0;0;0;0;1;FLOAT;0
Node;AmplifyShaderEditor.ViewDirInputsCoordNode;137;-3052.719,3270.273;Inherit;False;World;True;0;4;FLOAT3;0;FLOAT;1;FLOAT;2;FLOAT;3
Node;AmplifyShaderEditor.RangedFloatNode;135;-3045.824,3462.564;Inherit;False;Property;_power3;菲尼尔强度;13;0;Create;False;0;0;0;False;0;False;1;1;0;0;0;1;FLOAT;0
Node;AmplifyShaderEditor.ClampOpNode;633;432.7821,-2648.932;Inherit;False;3;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;1;False;1;FLOAT;0
Node;AmplifyShaderEditor.ClampOpNode;649;-4863.9,-3353.448;Inherit;False;3;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;1;False;1;FLOAT;0
Node;AmplifyShaderEditor.ClampOpNode;643;-4963.727,-4232.622;Inherit;False;3;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;1;False;1;FLOAT;0
Node;AmplifyShaderEditor.ClampOpNode;644;-4904.19,-4365.49;Inherit;False;3;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;1;False;1;FLOAT;0
Node;AmplifyShaderEditor.LerpOp;697;-6196.934,2164.658;Inherit;False;3;0;FLOAT2;0,0;False;1;FLOAT2;0,0;False;2;FLOAT;0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.LerpOp;62;-3015.105,-1184.664;Inherit;False;3;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.RangedFloatNode;25;-2123.618,-1099.983;Inherit;False;Constant;_Float3;Float 3;11;0;Create;True;0;0;0;False;0;False;1;0;0;0;0;1;FLOAT;0
Node;AmplifyShaderEditor.PannerNode;168;-5856.174,3229.119;Inherit;False;3;0;FLOAT2;0,0;False;2;FLOAT2;0,0;False;1;FLOAT;1;False;1;FLOAT2;0
Node;AmplifyShaderEditor.DynamicAppendNode;635;597.5201,-2424.939;Inherit;False;FLOAT2;4;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;0;False;3;FLOAT;0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.PannerNode;700;-6005.721,2225.346;Inherit;False;3;0;FLOAT2;0,0;False;2;FLOAT2;0,0;False;1;FLOAT;1;False;1;FLOAT2;0
Node;AmplifyShaderEditor.SimpleMultiplyOpNode;30;-1949.761,-1300.909;Inherit;False;2;2;0;FLOAT;0;False;1;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.PosVertexDataNode;98;-5310.597,-1068.886;Inherit;False;0;0;5;FLOAT3;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.RangedFloatNode;96;-5325.98,-906.5043;Inherit;False;Property;_Float16;软粒子（羽化边缘）;8;0;Create;False;0;0;0;False;2;Header(___________________________________________________________________________________________________________________________________________________________________________________________________________________________________________);Header(Depthfade);False;0;0;0;0;0;1;FLOAT;0
Node;AmplifyShaderEditor.DynamicAppendNode;650;-4689.343,-3161.368;Inherit;False;FLOAT2;4;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;0;False;3;FLOAT;0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.DynamicAppendNode;645;-4739.452,-4141.497;Inherit;False;FLOAT2;4;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;0;False;3;FLOAT;0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.PiNode;699;-6073.416,2554.414;Inherit;False;1;0;FLOAT;1;False;1;FLOAT;0
Node;AmplifyShaderEditor.PiNode;397;-5923.868,3558.187;Inherit;False;1;0;FLOAT;1;False;1;FLOAT;0
Node;AmplifyShaderEditor.SimpleAddOpNode;24;-2045.757,-1468.091;Inherit;False;2;2;0;FLOAT;0;False;1;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.RangedFloatNode;333;-5161.002,-838.8318;Inherit;False;Property;_Float5;反向软粒子(强化边缘）;9;1;[Toggle];Create;False;0;0;0;True;0;False;0;0;0;0;0;1;FLOAT;0
Node;AmplifyShaderEditor.FresnelNode;139;-2742.485,3325.885;Inherit;False;Standard;WorldNormal;ViewDir;True;True;5;0;FLOAT3;0,0,1;False;4;FLOAT3;0,0,0;False;1;FLOAT;0;False;2;FLOAT;1;False;3;FLOAT;5;False;1;FLOAT;0
Node;AmplifyShaderEditor.RegisterLocalVarNode;334;-4928.685,-852.5408;Inherit;False;depthfade_switch;-1;True;1;0;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.SaturateNode;140;-2505.02,3326.082;Inherit;False;1;0;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.StaticSwitch;651;-4635.388,-3453.031;Inherit;False;Property;_Keyword11;Mask02UV;51;0;Create;False;0;0;0;False;0;False;0;0;0;True;;KeywordEnum;2;Repeat;Clamp;Create;True;True;All;9;1;FLOAT2;0,0;False;0;FLOAT2;0,0;False;2;FLOAT2;0,0;False;3;FLOAT2;0,0;False;4;FLOAT2;0,0;False;5;FLOAT2;0,0;False;6;FLOAT2;0,0;False;7;FLOAT2;0,0;False;8;FLOAT2;0,0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.RotatorNode;701;-5917.052,2405.724;Inherit;False;3;0;FLOAT2;0,0;False;1;FLOAT2;0.5,0.5;False;2;FLOAT;1;False;1;FLOAT2;0
Node;AmplifyShaderEditor.CommentaryNode;114;-3280.871,-132.1433;Inherit;False;1936.036;770.2162; 亮边溶解;8;107;109;105;106;108;124;130;133;亮边溶解;1,1,1,1;0;0
Node;AmplifyShaderEditor.RotatorNode;398;-5767.505,3409.497;Inherit;False;3;0;FLOAT2;0,0;False;1;FLOAT2;0.5,0.5;False;2;FLOAT;1;False;1;FLOAT2;0
Node;AmplifyShaderEditor.DepthFade;97;-5079.145,-1069.461;Inherit;False;True;True;True;2;1;FLOAT3;0,0,0;False;0;FLOAT;1;False;1;FLOAT;0
Node;AmplifyShaderEditor.StaticSwitch;636;661.2943,-2748.515;Inherit;False;Property;_Keyword8;主贴图UV;24;0;Create;False;0;0;0;False;0;False;0;0;0;True;;KeywordEnum;2;Repeat;Clamp;Create;True;True;All;9;1;FLOAT2;0,0;False;0;FLOAT2;0,0;False;2;FLOAT2;0,0;False;3;FLOAT2;0,0;False;4;FLOAT2;0,0;False;5;FLOAT2;0,0;False;6;FLOAT2;0,0;False;7;FLOAT2;0,0;False;8;FLOAT2;0,0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.RangedFloatNode;33;-1826.332,-1100.916;Inherit;False;Property;_Float8;软硬;65;0;Create;False;0;0;0;False;0;False;0.5;0.5;0.5;1;0;1;FLOAT;0
Node;AmplifyShaderEditor.StaticSwitch;646;-4675.678,-4465.073;Inherit;False;Property;_Keyword10;Mask01UV;44;0;Create;False;0;0;0;False;0;False;0;0;0;True;;KeywordEnum;2;Repeat;Clamp;Create;True;True;All;9;1;FLOAT2;0,0;False;0;FLOAT2;0,0;False;2;FLOAT2;0,0;False;3;FLOAT2;0,0;False;4;FLOAT2;0,0;False;5;FLOAT2;0,0;False;6;FLOAT2;0,0;False;7;FLOAT2;0,0;False;8;FLOAT2;0,0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.SimpleSubtractOpNode;26;-1913.897,-1443.652;Inherit;False;2;0;FLOAT;0;False;1;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.SamplerNode;8;-4444.885,-4166.886;Inherit;True;Property;_Mask;遮罩01;42;1;[NoScaleOffset];Create;False;0;0;0;False;2;Header(___________________________________________________________________________________________________________________________________________________________________________________________________________________________________________);Header(Mask);False;-1;None;None;True;0;False;white;Auto;False;Object;-1;Auto;Texture2D;8;0;SAMPLER2D;;False;1;FLOAT2;0,0;False;2;FLOAT;0;False;3;FLOAT2;0,0;False;4;FLOAT2;0,0;False;5;FLOAT;1;False;6;FLOAT;0;False;7;SAMPLERSTATE;;False;5;COLOR;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.OneMinusNode;327;-4857.466,-987.5753;Inherit;False;1;0;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.SamplerNode;1;977.7087,-2360.174;Inherit;True;Property;_maintex;主贴图;22;1;[NoScaleOffset];Create;False;0;0;0;False;2;Header(___________________________________________________________________________________________________________________________________________________________________________________________________________________________________________);Header(Main);False;-1;None;17cb4d925908fb34a839d3d6299be0dd;True;0;False;white;Auto;False;Object;-1;Auto;Texture2D;8;0;SAMPLER2D;;False;1;FLOAT2;0,0;False;2;FLOAT;0;False;3;FLOAT2;0,0;False;4;FLOAT2;0,0;False;5;FLOAT;1;False;6;FLOAT;0;False;7;SAMPLERSTATE;;False;5;COLOR;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.OneMinusNode;34;-1779.874,-1333.926;Inherit;False;1;0;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.GetLocalVarNode;337;-4717.354,-875.0988;Inherit;False;334;depthfade_switch;1;0;OBJECT;;False;1;FLOAT;0
Node;AmplifyShaderEditor.BreakToComponentsNode;658;-5969.874,3817.694;Inherit;False;FLOAT2;1;0;FLOAT2;0,0;False;16;FLOAT;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4;FLOAT;5;FLOAT;6;FLOAT;7;FLOAT;8;FLOAT;9;FLOAT;10;FLOAT;11;FLOAT;12;FLOAT;13;FLOAT;14;FLOAT;15
Node;AmplifyShaderEditor.SaturateNode;45;-1691.772,-1471.419;Inherit;False;1;0;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.BreakToComponentsNode;702;-6119.421,2813.921;Inherit;False;FLOAT2;1;0;FLOAT2;0,0;False;16;FLOAT;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4;FLOAT;5;FLOAT;6;FLOAT;7;FLOAT;8;FLOAT;9;FLOAT;10;FLOAT;11;FLOAT;12;FLOAT;13;FLOAT;14;FLOAT;15
Node;AmplifyShaderEditor.RangedFloatNode;142;-2560.026,3560.687;Inherit;False;Property;_Float20;反向菲尼尔（虚化边缘）;15;1;[Toggle];Create;False;0;0;0;True;0;False;0;0;0;0;0;1;FLOAT;0
Node;AmplifyShaderEditor.OneMinusNode;141;-2409.202,3428.264;Inherit;False;1;0;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.SamplerNode;218;-4419.373,-3619.329;Inherit;True;Property;_Mask1;遮罩02;49;1;[NoScaleOffset];Create;False;0;0;0;False;0;False;-1;None;None;True;0;False;white;Auto;False;Object;-1;Auto;Texture2D;8;0;SAMPLER2D;;False;1;FLOAT2;0,0;False;2;FLOAT;0;False;3;FLOAT2;0,0;False;4;FLOAT2;0,0;False;5;FLOAT;1;False;6;FLOAT;0;False;7;SAMPLERSTATE;;False;5;COLOR;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.TFHCRemapNode;130;-2675.066,14.4076;Inherit;False;5;0;FLOAT;0;False;1;FLOAT;-0.5;False;2;FLOAT;1.5;False;3;FLOAT;0;False;4;FLOAT;1;False;1;FLOAT;0
Node;AmplifyShaderEditor.ClampOpNode;704;-5939.113,2811.471;Inherit;False;3;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;1;False;1;FLOAT;0
Node;AmplifyShaderEditor.StaticSwitch;606;-4133.613,-4052.545;Inherit;False;Property;_Keyword4;mask01通道;43;0;Create;False;0;0;0;False;0;False;0;0;0;True;;KeywordEnum;2;A;R;Create;True;True;All;9;1;FLOAT;0;False;0;FLOAT;0;False;2;FLOAT;0;False;3;FLOAT;0;False;4;FLOAT;0;False;5;FLOAT;0;False;6;FLOAT;0;False;7;FLOAT;0;False;8;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.StepOpNode;105;-2193.885,-61.45246;Inherit;True;2;0;FLOAT;0;False;1;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.LerpOp;144;-2176.633,3335.982;Inherit;False;3;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.ClampOpNode;660;-5793.702,3933.248;Inherit;False;3;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;1;False;1;FLOAT;0
Node;AmplifyShaderEditor.LerpOp;336;-4700.877,-1068.771;Inherit;False;3;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.ClampOpNode;703;-5943.25,2929.475;Inherit;False;3;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;1;False;1;FLOAT;0
Node;AmplifyShaderEditor.StaticSwitch;608;-4008.385,-3615.114;Inherit;False;Property;_Keyword6;mask02通道;50;0;Create;False;0;0;0;False;0;False;0;0;0;True;;KeywordEnum;2;A;R;Create;True;True;All;9;1;FLOAT;0;False;0;FLOAT;0;False;2;FLOAT;0;False;3;FLOAT;0;False;4;FLOAT;0;False;5;FLOAT;0;False;6;FLOAT;0;False;7;FLOAT;0;False;8;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.RangedFloatNode;365;1092.575,-1978.97;Inherit;False;Property;_Float34;主贴图细节对比度;27;0;Create;False;0;0;0;False;0;False;1;1;0;0;0;1;FLOAT;0
Node;AmplifyShaderEditor.SmoothstepOpNode;32;-1575.733,-1418.762;Inherit;False;3;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;1;False;1;FLOAT;0
Node;AmplifyShaderEditor.StaticSwitch;599;1354.498,-2198.877;Inherit;False;Property;_Keyword0;主贴图通道;23;0;Create;False;0;0;0;False;0;False;0;0;0;True;;KeywordEnum;2;A;R;Create;True;True;All;9;1;FLOAT;0;False;0;FLOAT;0;False;2;FLOAT;0;False;3;FLOAT;0;False;4;FLOAT;0;False;5;FLOAT;0;False;6;FLOAT;0;False;7;FLOAT;0;False;8;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.ClampOpNode;659;-5789.566,3815.244;Inherit;False;3;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;1;False;1;FLOAT;0
Node;AmplifyShaderEditor.DynamicAppendNode;705;-5701.406,2886.822;Inherit;False;FLOAT2;4;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;0;False;3;FLOAT;0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.SimpleMultiplyOpNode;220;-3989.657,-3913.844;Inherit;False;2;2;0;FLOAT;0;False;1;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.RegisterLocalVarNode;122;-1281.563,-1147.893;Inherit;False;dis_soft;-1;True;1;0;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.RegisterLocalVarNode;124;-1853.731,-72.641;Inherit;False;dis_bright;-1;True;1;0;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.RangedFloatNode;370;1095.05,-1881.995;Inherit;False;Property;_Float37;主贴图细节提亮;28;0;Create;False;0;0;0;False;0;False;1;1;0;0;0;1;FLOAT;0
Node;AmplifyShaderEditor.RegisterLocalVarNode;126;-4539.251,-1060.616;Inherit;False;depthfade;-1;True;1;0;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.DynamicAppendNode;661;-5551.859,3890.595;Inherit;False;FLOAT2;4;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;0;False;3;FLOAT;0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.RegisterLocalVarNode;147;-1878.385,3301.25;Inherit;False;fresnel;-1;True;1;0;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.PowerNode;372;1530.602,-1925.816;Inherit;False;False;2;0;FLOAT;0;False;1;FLOAT;1;False;1;FLOAT;0
Node;AmplifyShaderEditor.TextureCoordinatesNode;167;-5293.56,3874.986;Inherit;True;2;-1;4;3;2;SAMPLER2D;;False;0;FLOAT2;1,1;False;1;FLOAT2;0,0;False;5;FLOAT4;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.GetLocalVarNode;123;780.5142,-363.2022;Inherit;False;122;dis_soft;1;0;OBJECT;;False;1;FLOAT;0
Node;AmplifyShaderEditor.RangedFloatNode;414;936.9312,-119.5417;Inherit;False;Property;_Float25;开启亮边溶解;66;1;[Toggle];Create;False;0;0;0;True;0;False;0;1;0;0;0;1;FLOAT;0
Node;AmplifyShaderEditor.GetLocalVarNode;150;1240.176,-595.2217;Inherit;False;147;fresnel;1;0;OBJECT;;False;1;FLOAT;0
Node;AmplifyShaderEditor.RangedFloatNode;178;-5033.178,3793.593;Inherit;False;Constant;_Float21;Float 21;37;0;Create;True;0;0;0;False;0;False;1;0;0;0;0;1;FLOAT;0
Node;AmplifyShaderEditor.GetLocalVarNode;125;787.0208,-279.6117;Inherit;False;124;dis_bright;1;0;OBJECT;;False;1;FLOAT;0
Node;AmplifyShaderEditor.RegisterLocalVarNode;82;-3833.519,-3840.229;Inherit;False;Mask;-1;True;1;0;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.StaticSwitch;662;-5466.356,3672.013;Inherit;False;Property;_Keyword13;顶点偏移UV;84;0;Create;False;0;0;0;False;0;False;0;0;0;True;;KeywordEnum;2;Repeat;Clamp;Create;True;True;All;9;1;FLOAT2;0,0;False;0;FLOAT2;0,0;False;2;FLOAT2;0,0;False;3;FLOAT2;0,0;False;4;FLOAT2;0,0;False;5;FLOAT2;0,0;False;6;FLOAT2;0,0;False;7;FLOAT2;0,0;False;8;FLOAT2;0,0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.SimpleMultiplyOpNode;373;1680.865,-1842.245;Inherit;False;2;2;0;FLOAT;0;False;1;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.StaticSwitch;706;-5615.903,2668.24;Inherit;False;Property;_Keyword16;顶点偏移遮罩UV;90;0;Create;False;0;0;0;False;0;False;0;0;0;True;;KeywordEnum;2;Repeat;Clamp;Create;True;True;All;9;1;FLOAT2;0,0;False;0;FLOAT2;0,0;False;2;FLOAT2;0,0;False;3;FLOAT2;0,0;False;4;FLOAT2;0,0;False;5;FLOAT2;0,0;False;6;FLOAT2;0,0;False;7;FLOAT2;0,0;False;8;FLOAT2;0,0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.RangedFloatNode;367;1071.234,-1772.675;Inherit;False;Property;_Float36;细节平滑过渡;29;0;Create;False;0;0;0;False;0;False;1;0.5;0;1;0;1;FLOAT;0
Node;AmplifyShaderEditor.RangedFloatNode;209;1215.003,-684.2476;Inherit;False;Constant;_Float27;Float 27;43;0;Create;True;0;0;0;False;0;False;1;0;0;0;0;1;FLOAT;0
Node;AmplifyShaderEditor.GetLocalVarNode;128;1704.702,-96.59657;Inherit;False;126;depthfade;1;0;OBJECT;;False;1;FLOAT;0
Node;AmplifyShaderEditor.GetLocalVarNode;340;1694.996,9.14698;Inherit;False;334;depthfade_switch;1;0;OBJECT;;False;1;FLOAT;0
Node;AmplifyShaderEditor.RangedFloatNode;179;-5229.792,4148.097;Inherit;False;Property;_Float22;custom2w控制顶点偏移强度;109;1;[Toggle];Create;False;0;0;0;False;0;False;0;0;0;0;0;1;FLOAT;0
Node;AmplifyShaderEditor.VertexColorNode;3;685.7859,-1332.228;Inherit;False;0;5;COLOR;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.NormalVertexDataNode;172;-5095.266,3490.405;Inherit;False;0;5;FLOAT3;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.SamplerNode;707;-5411.813,2385.35;Inherit;True;Property;_vertextex1;顶点遮罩;89;1;[NoScaleOffset];Create;False;0;0;0;False;0;False;-1;None;None;True;0;False;white;Auto;False;Object;-1;Auto;Texture2D;8;0;SAMPLER2D;;False;1;FLOAT2;0,0;False;2;FLOAT;0;False;3;FLOAT2;0,0;False;4;FLOAT2;0,0;False;5;FLOAT;1;False;6;FLOAT;0;False;7;SAMPLERSTATE;;False;5;COLOR;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.SamplerNode;169;-5390.938,3367.677;Inherit;True;Property;_vertextex;顶点偏移贴图;83;1;[NoScaleOffset];Create;False;0;0;0;False;2;Header(___________________________________________________________________________________________________________________________________________________________________________________________________________________________________________);Header(Vertex);False;-1;None;None;True;0;False;white;Auto;False;Object;-1;Auto;Texture2D;8;0;SAMPLER2D;;False;1;FLOAT2;0,0;False;2;FLOAT;0;False;3;FLOAT2;0,0;False;4;FLOAT2;0,0;False;5;FLOAT;1;False;6;FLOAT;0;False;7;SAMPLERSTATE;;False;5;COLOR;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.RangedFloatNode;95;1391.645,-203.8996;Inherit;False;Property;_Float15;alpha强度;21;0;Create;False;0;0;0;False;0;False;1;1;0;10;0;1;FLOAT;0
Node;AmplifyShaderEditor.LerpOp;374;1977.591,-1725.544;Inherit;False;3;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.ColorNode;4;587.6035,-998.7886;Inherit;False;Property;_Color0;颜色;16;1;[HDR];Create;False;0;0;0;False;2;Header(___________________________________________________________________________________________________________________________________________________________________________________________________________________________________________);Header(color);False;1,1,1,1;2,1.066667,0.3686275,1;True;0;5;COLOR;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.GetLocalVarNode;221;1744.402,249.0229;Inherit;False;82;Mask;1;0;OBJECT;;False;1;FLOAT;0
Node;AmplifyShaderEditor.Vector3Node;175;-5145.438,3647.798;Inherit;False;Property;_Vector5;顶点偏移强度;95;0;Create;False;0;0;0;False;0;False;0,0,0;0,0,0;0;4;FLOAT3;0;FLOAT;1;FLOAT;2;FLOAT;3
Node;AmplifyShaderEditor.LerpOp;176;-4764.42,3743.857;Inherit;False;3;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.LerpOp;338;2090.468,-65.99885;Inherit;False;3;0;FLOAT;1;False;1;FLOAT;1;False;2;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.StaticSwitch;615;1652.445,-759.1202;Inherit;False;Property;_Keyword5;菲尼尔开关;12;0;Create;False;0;0;0;False;2;Header(___________________________________________________________________________________________________________________________________________________________________________________________________________________________________________);Header(Fresnel);False;0;0;0;True;;KeywordEnum;2;Off;On;Create;True;True;All;9;1;FLOAT;0;False;0;FLOAT;0;False;2;FLOAT;0;False;3;FLOAT;0;False;4;FLOAT;0;False;5;FLOAT;0;False;6;FLOAT;0;False;7;FLOAT;0;False;8;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.LerpOp;413;1213.873,-320.4856;Inherit;False;3;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.SimpleMultiplyOpNode;6;2803.02,-421.6413;Inherit;False;8;8;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;0;False;3;FLOAT;0;False;4;FLOAT;0;False;5;FLOAT;0;False;6;FLOAT;0;False;7;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.SimpleMultiplyOpNode;171;-4772.044,3396.111;Inherit;False;5;5;0;FLOAT;0;False;1;FLOAT3;0,0,0;False;2;FLOAT3;0,0,0;False;3;FLOAT;0;False;4;FLOAT;0;False;1;FLOAT3;0
Node;AmplifyShaderEditor.CommentaryNode;466;-3491.589,-2958.825;Inherit;False;1953.631;872.0986;Comment;16;459;455;456;457;226;460;458;454;453;461;463;464;229;231;611;612;Ramptex;1,1,1,1;0;0
Node;AmplifyShaderEditor.CommentaryNode;588;-3244.336,1907.054;Inherit;False;3124.205;1004.605;Comment;35;194;193;201;188;191;190;202;203;185;183;196;576;580;582;583;584;585;579;587;186;195;192;575;581;586;577;578;589;590;591;668;669;670;671;672;折射;1,1,1,1;0;0
Node;AmplifyShaderEditor.RegisterLocalVarNode;181;-4599.378,3411.561;Inherit;False;vertexoffset;-1;True;1;0;FLOAT3;0,0,0;False;1;FLOAT3;0
Node;AmplifyShaderEditor.ClampOpNode;616;2952.858,-778.8079;Inherit;False;3;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;1;False;1;FLOAT;0
Node;AmplifyShaderEditor.RangedFloatNode;591;-1997.892,2357.983;Inherit;False;Property;_Float59;折射贴图旋转;99;0;Create;False;0;0;0;False;0;False;0;0;-1;1;0;1;FLOAT;0
Node;AmplifyShaderEditor.ColorNode;718;1334.629,-1556.326;Inherit;False;Property;blendcolor;混合图颜色;34;1;[HDR];Create;False;0;0;0;False;0;False;0,0,0,0;1,0.5618839,0.1568627,0;True;0;5;COLOR;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.LerpOp;585;-1942.312,2106.268;Inherit;False;3;0;FLOAT2;0,0;False;1;FLOAT2;0,0;False;2;FLOAT;0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.RangedFloatNode;192;-1585.979,2465.205;Inherit;False;Property;_Float23;折射（热扭曲）强度;103;0;Create;False;0;0;0;False;0;False;0;0;0;0;0;1;FLOAT;0
Node;AmplifyShaderEditor.GetLocalVarNode;232;-680.9304,-1340.265;Inherit;False;70;noise;1;0;OBJECT;;False;1;FLOAT;0
Node;AmplifyShaderEditor.RangedFloatNode;597;-8087.689,-1123.75;Inherit;False;Property;_Float46;stencil_reference;7;0;Create;False;0;0;0;True;0;False;0;0;0;0;0;1;FLOAT;0
Node;AmplifyShaderEditor.FunctionNode;460;-2801.418,-2881.551;Inherit;False;Polar Coordinates;-1;;48;7dab8e02884cf104ebefaa2e788e4162;0;4;1;FLOAT2;0,0;False;2;FLOAT2;0.5,0.5;False;3;FLOAT;1;False;4;FLOAT;1;False;1;FLOAT2;0
Node;AmplifyShaderEditor.StaticSwitch;641;571.1607,-1703.836;Inherit;False;Property;_Keyword9;ramptexUV;35;0;Create;False;0;0;0;False;0;False;0;0;0;True;;KeywordEnum;2;Repeat;Clamp;Create;True;True;All;9;1;FLOAT2;0,0;False;0;FLOAT2;0,0;False;2;FLOAT2;0,0;False;3;FLOAT2;0,0;False;4;FLOAT2;0,0;False;5;FLOAT2;0,0;False;6;FLOAT2;0,0;False;7;FLOAT2;0,0;False;8;FLOAT2;0,0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.RotatorNode;383;-125.8229,-1685.201;Inherit;False;3;0;FLOAT2;0,0;False;1;FLOAT2;0.5,0.5;False;2;FLOAT;1;False;1;FLOAT2;0
Node;AmplifyShaderEditor.TextureCoordinatesNode;226;-3341.196,-2906.825;Inherit;False;0;212;2;3;2;SAMPLER2D;;False;0;FLOAT2;1,1;False;1;FLOAT2;0,0;False;5;FLOAT2;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.FunctionNode;576;-2539.336,1957.054;Inherit;False;Polar Coordinates;-1;;47;7dab8e02884cf104ebefaa2e788e4162;0;4;1;FLOAT2;0,0;False;2;FLOAT2;0.5,0.5;False;3;FLOAT;1;False;4;FLOAT;1;False;1;FLOAT2;0
Node;AmplifyShaderEditor.RotatorNode;589;-1531.806,2221.83;Inherit;False;3;0;FLOAT2;0,0;False;1;FLOAT2;0.5,0.5;False;2;FLOAT;1;False;1;FLOAT2;0
Node;AmplifyShaderEditor.GetLocalVarNode;233;-709.4964,-1222.115;Inherit;False;67;noise_intensity_main;1;0;OBJECT;;False;1;FLOAT;0
Node;AmplifyShaderEditor.StepOpNode;107;-2396.322,226.6806;Inherit;True;2;0;FLOAT;0;False;1;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.RangedFloatNode;213;1030.115,-1381.015;Inherit;False;Property;_Float29;颜色混合（lerp模式下使用）;41;0;Create;False;0;0;0;False;0;False;0;0;0;1;0;1;FLOAT;0
Node;AmplifyShaderEditor.RangedFloatNode;381;-768.3331,-1685.647;Inherit;False;Property;_Float40;颜色混合贴图旋转;36;0;Create;False;0;0;0;False;0;False;0;0;-1;1;0;1;FLOAT;0
Node;AmplifyShaderEditor.DynamicAppendNode;587;-2649.12,2335.77;Inherit;False;FLOAT2;4;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;0;False;3;FLOAT;0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.SimpleAddOpNode;109;-2819.345,229.5152;Inherit;False;2;2;0;FLOAT;0;False;1;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.DynamicAppendNode;454;-2833.848,-2644.533;Inherit;False;FLOAT2;4;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;0;False;3;FLOAT;0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.SimpleAddOpNode;582;-2389.344,2394.38;Inherit;False;2;2;0;FLOAT2;0,0;False;1;FLOAT2;0,0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.LerpOp;359;1092.049,-867.6227;Inherit;False;3;0;COLOR;0,0,0,0;False;1;COLOR;0,0,0,0;False;2;FLOAT;0;False;1;COLOR;0
Node;AmplifyShaderEditor.ScaleAndOffsetNode;584;-2171.536,1998.739;Inherit;False;3;0;FLOAT2;0,0;False;1;FLOAT2;1,1;False;2;FLOAT2;0,0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.BreakToComponentsNode;637;130.2405,-1635.53;Inherit;False;FLOAT2;1;0;FLOAT2;0,0;False;16;FLOAT;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4;FLOAT;5;FLOAT;6;FLOAT;7;FLOAT;8;FLOAT;9;FLOAT;10;FLOAT;11;FLOAT;12;FLOAT;13;FLOAT;14;FLOAT;15
Node;AmplifyShaderEditor.GetLocalVarNode;332;1591.33,-2725.519;Inherit;False;126;depthfade;1;0;OBJECT;;False;1;FLOAT;0
Node;AmplifyShaderEditor.DynamicAppendNode;579;-2779.336,2565.054;Inherit;False;FLOAT2;4;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;0;False;3;FLOAT;0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.BreakToComponentsNode;668;-1682.892,1941.713;Inherit;False;FLOAT2;1;0;FLOAT2;0,0;False;16;FLOAT;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4;FLOAT;5;FLOAT;6;FLOAT;7;FLOAT;8;FLOAT;9;FLOAT;10;FLOAT;11;FLOAT;12;FLOAT;13;FLOAT;14;FLOAT;15
Node;AmplifyShaderEditor.RegisterLocalVarNode;231;-1761.959,-2689.409;Inherit;False;Gradienttex;-1;True;1;0;FLOAT2;0,0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.LerpOp;193;-1301.284,2521.537;Inherit;False;3;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.SimpleSubtractOpNode;455;-3062.256,-2721.197;Inherit;False;2;0;FLOAT;0;False;1;FLOAT;1;False;1;FLOAT;0
Node;AmplifyShaderEditor.ClampOpNode;670;-1506.72,2057.266;Inherit;False;3;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;1;False;1;FLOAT;0
Node;AmplifyShaderEditor.RangedFloatNode;195;-1641.269,2795.659;Inherit;False;Property;_Float24;custom2z控制折射（热扭曲）;108;1;[Toggle];Create;False;0;0;0;True;0;False;0;0;0;0;0;1;FLOAT;0
Node;AmplifyShaderEditor.ClampOpNode;639;342.6484,-1604.253;Inherit;False;3;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;1;False;1;FLOAT;0
Node;AmplifyShaderEditor.SimpleSubtractOpNode;456;-3061.453,-2599.537;Inherit;False;2;0;FLOAT;0;False;1;FLOAT;1;False;1;FLOAT;0
Node;AmplifyShaderEditor.ClampOpNode;638;283.1114,-1471.385;Inherit;False;3;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;1;False;1;FLOAT;0
Node;AmplifyShaderEditor.StaticSwitch;716;1293.654,-1712.78;Inherit;False;Property;_Keyword1;混合颜色贴图通道;33;0;Create;False;0;0;0;False;0;False;0;0;0;True;;KeywordEnum;2;RGB;R;Create;True;True;All;9;1;COLOR;0,0,0,0;False;0;COLOR;0,0,0,0;False;2;COLOR;0,0,0,0;False;3;COLOR;0,0,0,0;False;4;COLOR;0,0,0,0;False;5;COLOR;0,0,0,0;False;6;COLOR;0,0,0,0;False;7;COLOR;0,0,0,0;False;8;COLOR;0,0,0,0;False;1;COLOR;0
Node;AmplifyShaderEditor.ClampOpNode;669;-1502.585,1939.262;Inherit;False;3;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;1;False;1;FLOAT;0
Node;AmplifyShaderEditor.DynamicAppendNode;457;-3028.918,-2470.261;Inherit;False;FLOAT2;4;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;0;False;3;FLOAT;0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.StaticSwitch;614;3064.125,-1322.168;Inherit;False;Property;_Keyword2;折射（热扭曲）开关;97;0;Create;False;0;0;0;False;0;False;0;0;0;True;;KeywordEnum;2;Off;On;Create;True;True;All;9;1;COLOR;0,0,0,0;False;0;COLOR;0,0,0,0;False;2;COLOR;0,0,0,0;False;3;COLOR;0,0,0,0;False;4;COLOR;0,0,0,0;False;5;COLOR;0,0,0,0;False;6;COLOR;0,0,0,0;False;7;COLOR;0,0,0,0;False;8;COLOR;0,0,0,0;False;1;COLOR;0
Node;AmplifyShaderEditor.DynamicAppendNode;640;507.3864,-1380.26;Inherit;False;FLOAT2;4;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;0;False;3;FLOAT;0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.RangedFloatNode;346;1865.897,-2501.937;Inherit;False;Property;_Float30;边缘收窄;11;0;Create;False;0;0;0;False;0;False;1;1;0;0;0;1;FLOAT;0
Node;AmplifyShaderEditor.GetLocalVarNode;335;1586.263,-2628.355;Inherit;False;334;depthfade_switch;1;0;OBJECT;;False;1;FLOAT;0
Node;AmplifyShaderEditor.RangedFloatNode;586;-2330.196,2627.662;Inherit;False;Property;_Float58;折射极坐标开关;100;1;[Toggle];Create;False;0;0;0;False;0;False;0;0;0;0;0;1;FLOAT;0
Node;AmplifyShaderEditor.RangedFloatNode;94;1549.959,-962.4984;Inherit;False;Property;_Float14;整体颜色强度;17;0;Create;False;0;0;0;False;0;False;1;1;0;0;0;1;FLOAT;0
Node;AmplifyShaderEditor.Vector4Node;459;-3441.589,-2646.507;Inherit;False;Property;_Vector9;颜色混合图tilling&offset;38;0;Create;False;0;0;0;False;0;False;1,1,0,0;10,10,0,0;0;5;FLOAT4;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.SimpleMultiplyOpNode;191;-1049.162,2503.939;Inherit;False;2;2;0;FLOAT;0;False;1;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.SimpleMultiplyOpNode;203;-735.3391,2437.615;Inherit;False;2;2;0;FLOAT;0;False;1;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.LerpOp;611;-2187.37,-2758.483;Inherit;False;3;0;FLOAT2;0,0;False;1;FLOAT2;0,0;False;2;FLOAT;0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.RangedFloatNode;20;-8071.956,-1655.507;Inherit;False;Property;_Float4;深度写入;2;1;[Toggle];Create;False;0;0;1;UnityEngine.Rendering.CullMode;True;0;False;0;0;0;0;0;1;FLOAT;0
Node;AmplifyShaderEditor.ScaleAndOffsetNode;583;-2238.988,2217.098;Inherit;False;3;0;FLOAT2;0,0;False;1;FLOAT2;0,0;False;2;FLOAT2;0,0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.DynamicAppendNode;671;-1264.878,2014.614;Inherit;False;FLOAT2;4;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;0;False;3;FLOAT;0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.LerpOp;330;1855.548,-2683.016;Inherit;False;3;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.SimpleSubtractOpNode;577;-2798.336,2332.054;Inherit;False;2;0;FLOAT;0;False;1;FLOAT;1;False;1;FLOAT;0
Node;AmplifyShaderEditor.RangedFloatNode;612;-2458.347,-2509.01;Inherit;False;Property;_Float61;ramptex极坐标开关;37;1;[Toggle];Create;False;0;0;0;False;0;False;0;0;0;0;0;1;FLOAT;0
Node;AmplifyShaderEditor.RangedFloatNode;596;-8085.98,-1205.832;Inherit;False;Property;_Ztestmode2;stencil_pass;6;1;[Enum];Create;False;0;0;1;UnityEngine.Rendering.StencilOp;True;0;False;0;0;0;0;0;1;FLOAT;0
Node;AmplifyShaderEditor.SamplerNode;190;-1044.728,2210.355;Inherit;True;Property;_reftex; 折射（热扭曲）贴图;96;1;[NoScaleOffset];Create;False;0;0;0;False;2;Header(___________________________________________________________________________________________________________________________________________________________________________________________________________________________________________);Header(Ref);False;-1;None;None;True;0;False;white;Auto;False;Object;-1;Auto;Texture2D;8;0;SAMPLER2D;;False;1;FLOAT2;0,0;False;2;FLOAT;0;False;3;FLOAT2;0,0;False;4;FLOAT2;0,0;False;5;FLOAT;1;False;6;FLOAT;0;False;7;SAMPLERSTATE;;False;5;COLOR;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.StaticSwitch;603;1991.057,-2217.848;Inherit;False;Property;_Keyword3;颜色混合模式;40;0;Create;False;0;0;0;False;0;False;0;0;0;True;;KeywordEnum;2;Lerp;Multiply;Create;True;True;All;9;1;COLOR;0,0,0,0;False;0;COLOR;0,0,0,0;False;2;COLOR;0,0,0,0;False;3;COLOR;0,0,0,0;False;4;COLOR;0,0,0,0;False;5;COLOR;0,0,0,0;False;6;COLOR;0,0,0,0;False;7;COLOR;0,0,0,0;False;8;COLOR;0,0,0,0;False;1;COLOR;0
Node;AmplifyShaderEditor.ScreenColorNode;183;-539.8561,2108.272;Inherit;False;Global;_GrabScreen0;Grab Screen 0;1;0;Create;True;0;0;0;False;0;False;Object;-1;False;False;False;False;2;0;FLOAT2;0,0;False;1;FLOAT;0;False;5;COLOR;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.Vector4Node;581;-3153.697,2629.697;Inherit;False;Property;_Vector21;折射流动速度;102;0;Create;False;0;0;0;False;0;False;0,0,0,0;0,0,0,0;0;5;FLOAT4;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.SimpleAddOpNode;329;2524.175,-2135.368;Inherit;False;2;2;0;FLOAT;0;False;1;COLOR;0,0,0,0;False;1;COLOR;0
Node;AmplifyShaderEditor.RangedFloatNode;21;-8077.943,-1558.899;Inherit;False;Property;_Ztestmode;深度测试;3;1;[Enum];Create;False;0;0;1;UnityEngine.Rendering.CompareFunction;True;0;False;4;4;0;0;0;1;FLOAT;0
Node;AmplifyShaderEditor.StaticSwitch;672;-1199.842,2145.803;Inherit;False;Property;_Keyword15;折射UV;98;0;Create;False;0;0;0;False;0;False;0;0;0;True;;KeywordEnum;2;Repeat;Clamp;Create;True;True;All;9;1;FLOAT2;0,0;False;0;FLOAT2;0,0;False;2;FLOAT2;0,0;False;3;FLOAT2;0,0;False;4;FLOAT2;0,0;False;5;FLOAT2;0,0;False;6;FLOAT2;0,0;False;7;FLOAT2;0,0;False;8;FLOAT2;0,0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.PowerNode;345;2050.99,-2640.186;Inherit;False;False;2;0;FLOAT;0;False;1;FLOAT;1;False;1;FLOAT;0
Node;AmplifyShaderEditor.RangedFloatNode;201;-1370.826,2398.654;Inherit;False;Constant;_Float26;Float 26;43;0;Create;True;0;0;0;False;0;False;0.1;0;0;0;0;1;FLOAT;0
Node;AmplifyShaderEditor.DynamicAppendNode;580;-2763.697,2690.697;Inherit;False;FLOAT2;4;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;0;False;3;FLOAT;0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.SimpleMultiplyOpNode;5;2322.661,-1782.043;Inherit;False;7;7;0;COLOR;0,0,0,0;False;1;COLOR;0,0,0,0;False;2;COLOR;0,0,0,0;False;3;FLOAT;0;False;4;FLOAT;0;False;5;FLOAT;0;False;6;COLOR;0,0,0,0;False;1;COLOR;0
Node;AmplifyShaderEditor.RangedFloatNode;13;-8090.629,-1758.14;Inherit;False;Property;_Float1;材质模式;0;1;[Enum];Create;False;0;2;blend;10;add;1;0;True;0;False;10;10;0;0;0;1;FLOAT;0
Node;AmplifyShaderEditor.GetLocalVarNode;134;2015.855,-860.2697;Inherit;False;133;dis_edge;1;0;OBJECT;;False;1;FLOAT;0
Node;AmplifyShaderEditor.RangedFloatNode;343;1800.582,-2919.983;Inherit;False;Property;_Float28;边缘强度;10;0;Create;False;0;0;0;False;0;False;1;1;0;0;0;1;FLOAT;0
Node;AmplifyShaderEditor.ColorNode;357;597.2336,-800.0717;Inherit;False;Property;_Color3;颜色2;19;1;[HDR];Create;False;0;0;0;False;0;False;1,1,1,1;1,1,1,1;True;0;5;COLOR;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.SimpleSubtractOpNode;108;-1926.81,128.6884;Inherit;True;2;0;FLOAT;0;False;1;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.GetLocalVarNode;234;-692.2724,-1475.574;Inherit;False;231;Gradienttex;1;0;OBJECT;;False;1;FLOAT2;0
Node;AmplifyShaderEditor.LerpOp;131;2355.473,-1337.025;Inherit;False;3;0;COLOR;0,0,0,0;False;1;COLOR;0,0,0,0;False;2;FLOAT;0;False;1;COLOR;0
Node;AmplifyShaderEditor.RangedFloatNode;595;-8082.98,-1300.832;Inherit;False;Property;_Ztestmode1;stencil_comp;5;1;[Enum];Create;False;0;0;1;UnityEngine.Rendering.CompareFunction;True;0;False;0;0;0;0;0;1;FLOAT;0
Node;AmplifyShaderEditor.SimpleAddOpNode;185;-683.3252,2113.102;Inherit;False;2;2;0;FLOAT4;0,0,0,0;False;1;FLOAT;0;False;1;FLOAT4;0
Node;AmplifyShaderEditor.TextureCoordinatesNode;186;-3107.478,2009.884;Inherit;False;0;190;2;3;2;SAMPLER2D;;False;0;FLOAT2;1,1;False;1;FLOAT2;0,0;False;5;FLOAT2;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.RangedFloatNode;22;-8072.098,-1379.883;Inherit;False;Property;_Float2;双面模式;1;1;[Enum];Create;False;0;0;1;UnityEngine.Rendering.CullMode;True;0;False;0;0;0;0;0;1;FLOAT;0
Node;AmplifyShaderEditor.RangedFloatNode;598;-8080.473,-1486.006;Inherit;False;Property;_Float60;colormask;4;1;[Enum];Create;False;0;0;1;UnityEngine.Rendering.ColorWriteMask;True;0;False;15;15;0;0;0;1;FLOAT;0
Node;AmplifyShaderEditor.Vector4Node;463;-3076.266,-2298.727;Inherit;False;Property;_Vector7;颜色图流动速度;39;0;Create;False;0;0;0;False;0;False;0,0,0,0;0,0,0,0;0;5;FLOAT4;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.ColorNode;132;2001.898,-1089.348;Inherit;False;Property;_Color1;亮边颜色;68;1;[HDR];Create;False;0;0;0;False;0;False;1,1,1,1;0.5471698,0.1518325,0,1;True;0;5;COLOR;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.RegisterLocalVarNode;196;-344.1315,2114.849;Inherit;False;ref;-1;True;1;0;COLOR;0,0,0,0;False;1;COLOR;0
Node;AmplifyShaderEditor.GrabScreenPosition;202;-1016.412,1953.442;Inherit;False;0;0;5;FLOAT4;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.SimpleSubtractOpNode;578;-2797.336,2429.054;Inherit;False;2;0;FLOAT;0;False;1;FLOAT;1;False;1;FLOAT;0
Node;AmplifyShaderEditor.SwitchByFaceNode;356;1275.117,-1003.317;Inherit;False;2;0;COLOR;0,0,0,0;False;1;COLOR;0,0,0,0;False;1;COLOR;0
Node;AmplifyShaderEditor.PiNode;382;-397.6094,-1678.741;Inherit;False;1;0;FLOAT;1;False;1;FLOAT;0
Node;AmplifyShaderEditor.PiNode;590;-1690.095,2372.015;Inherit;False;1;0;FLOAT;1;False;1;FLOAT;0
Node;AmplifyShaderEditor.SimpleAddOpNode;458;-2720.784,-2453.009;Inherit;False;2;2;0;FLOAT2;0,0;False;1;FLOAT2;0,0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.RegisterLocalVarNode;133;-1627.403,47.66605;Inherit;False;dis_edge;-1;True;1;0;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.DynamicAppendNode;464;-2708.271,-2266.647;Inherit;False;FLOAT2;4;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;0;False;3;FLOAT;0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.PannerNode;188;-1728.906,2137.839;Inherit;False;3;0;FLOAT2;0,0;False;2;FLOAT2;0,0;False;1;FLOAT;1;False;1;FLOAT2;0
Node;AmplifyShaderEditor.ScaleAndOffsetNode;461;-2447.583,-2900.376;Inherit;False;3;0;FLOAT2;0,0;False;1;FLOAT2;1,1;False;2;FLOAT2;0,0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.ScaleAndOffsetNode;453;-2565.789,-2636.337;Inherit;False;3;0;FLOAT2;0,0;False;1;FLOAT2;0,0;False;2;FLOAT2;0,0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.GetLocalVarNode;182;3391.537,-591.7491;Inherit;False;181;vertexoffset;1;0;OBJECT;;False;1;FLOAT3;0
Node;AmplifyShaderEditor.PannerNode;229;-1998.32,-2691.945;Inherit;False;3;0;FLOAT2;0,0;False;2;FLOAT2;0,0;False;1;FLOAT;1;False;1;FLOAT2;0
Node;AmplifyShaderEditor.SimpleMultiplyOpNode;717;1557.101,-1650.052;Inherit;True;2;2;0;COLOR;0,0,0,0;False;1;COLOR;0,0,0,0;False;1;COLOR;0
Node;AmplifyShaderEditor.Vector4Node;575;-3194.336,2293.054;Inherit;False;Property;_Vector20;折射_tilling&offset;101;0;Create;False;0;0;0;False;0;False;1,1,0,0;1,1,0,0;0;5;FLOAT4;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.LerpOp;235;-371.6005,-1526.742;Inherit;False;3;0;FLOAT2;0,0;False;1;FLOAT2;0,0;False;2;FLOAT;0;False;1;FLOAT2;0
Node;AmplifyShaderEditor.GetLocalVarNode;199;2655.782,-1187.266;Inherit;False;196;ref;1;0;OBJECT;;False;1;COLOR;0
Node;AmplifyShaderEditor.SamplerNode;212;965.8965,-1679.104;Inherit;True;Property;_Gradienttex;混合颜色贴图;32;1;[NoScaleOffset];Create;False;0;0;0;False;1;Header(Ramptex);False;-1;None;12c812a4d3c33984ca2a8988d6bbeefc;True;0;False;white;Auto;False;Object;-1;Auto;Texture2D;8;0;SAMPLER2D;;False;1;FLOAT2;0,0;False;2;FLOAT;0;False;3;FLOAT2;0,0;False;4;FLOAT2;0,0;False;5;FLOAT;1;False;6;FLOAT;0;False;7;SAMPLERSTATE;;False;5;COLOR;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.SimpleMultiplyOpNode;341;2128.417,-2798.06;Inherit;False;2;2;0;FLOAT;0;False;1;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.SimpleMultiplyOpNode;605;1773.06,-2205.357;Inherit;False;2;2;0;COLOR;0,0,0,0;False;1;COLOR;0,0,0,0;False;1;COLOR;0
Node;AmplifyShaderEditor.RangedFloatNode;358;679.5315,-578.705;Inherit;False;Property;_Float35;启用第二面颜色;18;1;[Toggle];Create;False;0;0;0;True;0;False;0;0;0;0;0;1;FLOAT;0
Node;AmplifyShaderEditor.LerpOp;211;1681.952,-2376.293;Inherit;False;3;0;COLOR;0,0,0,0;False;1;COLOR;0,0,0,0;False;2;FLOAT;0;False;1;COLOR;0
Node;AmplifyShaderEditor.TextureCoordinatesNode;194;-1854.385,2530.938;Inherit;True;2;-1;4;3;2;SAMPLER2D;;False;0;FLOAT2;1,1;False;1;FLOAT2;0,0;False;5;FLOAT4;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.StaticSwitch;617;3133.569,-828.9205;Inherit;False;Property;_Keyword7;AlphaClamp;20;0;Create;False;0;0;0;False;0;False;0;0;0;True;;KeywordEnum;2;Off;On;Create;True;True;All;9;1;FLOAT;0;False;0;FLOAT;0;False;2;FLOAT;0;False;3;FLOAT;0;False;4;FLOAT;0;False;5;FLOAT;0;False;6;FLOAT;0;False;7;FLOAT;0;False;8;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.RangedFloatNode;106;-3237.024,246.0084;Inherit;False;Property;_Float17;亮边宽度;67;0;Create;False;0;0;0;False;0;False;0;0.1;0;0.2;0;1;FLOAT;0
Node;AmplifyShaderEditor.TemplateMultiPassMasterNode;709;3791.423,-927.4819;Float;False;False;-1;2;UnityEditor.ShaderGraph.PBRMasterGUI;0;1;New Amplify Shader;2992e84f91cbeb14eab234972e07ea9d;True;ExtraPrePass;0;0;ExtraPrePass;5;False;False;False;False;False;False;False;False;False;False;False;False;True;0;False;-1;False;True;0;False;-1;False;False;False;False;False;False;False;False;False;True;False;255;False;-1;255;False;-1;255;False;-1;7;False;-1;1;False;-1;1;False;-1;1;False;-1;7;False;-1;1;False;-1;1;False;-1;1;False;-1;False;False;False;False;True;3;RenderPipeline=UniversalPipeline;RenderType=Opaque=RenderType;Queue=Geometry=Queue=0;True;0;True;17;d3d9;d3d11;glcore;gles;gles3;metal;vulkan;xbox360;xboxone;xboxseries;ps4;playstation;psp2;n3ds;wiiu;switch;nomrt;0;False;True;1;1;False;-1;0;False;-1;0;1;False;-1;0;False;-1;False;False;False;False;False;False;False;False;False;False;False;False;True;0;False;-1;False;True;True;True;True;True;0;False;-1;False;False;False;False;False;False;False;True;False;255;False;-1;255;False;-1;255;False;-1;7;False;-1;1;False;-1;1;False;-1;1;False;-1;7;False;-1;1;False;-1;1;False;-1;1;False;-1;False;True;1;False;-1;True;3;False;-1;True;True;0;False;-1;0;False;-1;True;0;False;False;0;Hidden/InternalErrorShader;0;0;Standard;0;False;0
Node;AmplifyShaderEditor.TemplateMultiPassMasterNode;711;3791.423,-927.4819;Float;False;False;-1;2;UnityEditor.ShaderGraph.PBRMasterGUI;0;1;New Amplify Shader;2992e84f91cbeb14eab234972e07ea9d;True;ShadowCaster;0;2;ShadowCaster;0;False;False;False;False;False;False;False;False;False;False;False;False;True;0;False;-1;False;True;0;False;-1;False;False;False;False;False;False;False;False;False;True;False;255;False;-1;255;False;-1;255;False;-1;7;False;-1;1;False;-1;1;False;-1;1;False;-1;7;False;-1;1;False;-1;1;False;-1;1;False;-1;False;False;False;False;True;3;RenderPipeline=UniversalPipeline;RenderType=Opaque=RenderType;Queue=Geometry=Queue=0;True;0;True;17;d3d9;d3d11;glcore;gles;gles3;metal;vulkan;xbox360;xboxone;xboxseries;ps4;playstation;psp2;n3ds;wiiu;switch;nomrt;0;False;False;False;False;False;False;False;False;False;False;False;False;True;0;False;-1;False;False;False;True;False;False;False;False;0;False;-1;False;False;False;False;False;False;False;False;False;True;1;False;-1;True;3;False;-1;False;True;1;LightMode=ShadowCaster;False;False;0;Hidden/InternalErrorShader;0;0;Standard;0;False;0
Node;AmplifyShaderEditor.TemplateMultiPassMasterNode;713;3791.423,-927.4819;Float;False;False;-1;2;UnityEditor.ShaderGraph.PBRMasterGUI;0;1;New Amplify Shader;2992e84f91cbeb14eab234972e07ea9d;True;Meta;0;4;Meta;0;False;False;False;False;False;False;False;False;False;False;False;False;True;0;False;-1;False;True;0;False;-1;False;False;False;False;False;False;False;False;False;True;False;255;False;-1;255;False;-1;255;False;-1;7;False;-1;1;False;-1;1;False;-1;1;False;-1;7;False;-1;1;False;-1;1;False;-1;1;False;-1;False;False;False;False;True;3;RenderPipeline=UniversalPipeline;RenderType=Opaque=RenderType;Queue=Geometry=Queue=0;True;0;True;17;d3d9;d3d11;glcore;gles;gles3;metal;vulkan;xbox360;xboxone;xboxseries;ps4;playstation;psp2;n3ds;wiiu;switch;nomrt;0;False;False;False;False;False;False;False;False;False;False;False;False;False;False;True;2;False;-1;False;False;False;False;False;False;False;False;False;False;False;False;False;False;True;1;LightMode=Meta;False;False;0;Hidden/InternalErrorShader;0;0;Standard;0;False;0
Node;AmplifyShaderEditor.TemplateMultiPassMasterNode;710;3884.086,-973.8132;Float;False;True;-1;2;UnityEditor.ShaderGraph.PBRMasterGUI;0;3;Hotwater/2022/Urp_All_1230;2992e84f91cbeb14eab234972e07ea9d;True;Forward;0;1;Forward;8;False;False;False;False;False;False;False;False;False;False;False;False;True;0;False;-1;True;True;0;True;22;False;False;False;False;False;False;False;False;False;True;False;255;False;-1;255;False;-1;255;False;-1;7;False;-1;1;False;-1;1;False;-1;1;False;-1;7;False;-1;1;False;-1;1;False;-1;1;False;-1;False;False;False;False;True;3;RenderPipeline=UniversalPipeline;RenderType=Transparent=RenderType;Queue=Transparent=Queue=0;True;0;True;17;d3d9;d3d11;glcore;gles;gles3;metal;vulkan;xbox360;xboxone;xboxseries;ps4;playstation;psp2;n3ds;wiiu;switch;nomrt;0;True;True;2;5;False;-1;10;True;13;1;1;False;-1;10;False;-1;False;False;False;False;False;False;False;False;False;False;False;False;False;True;True;True;True;True;True;0;True;598;False;False;False;False;False;False;True;True;True;255;True;597;255;False;-1;255;False;-1;7;True;595;1;True;596;1;False;-1;1;False;-1;7;False;-1;1;False;-1;1;False;-1;1;False;-1;True;True;2;True;20;True;3;True;21;True;True;0;False;-1;0;False;-1;True;1;LightMode=UniversalForward;False;False;0;Hidden/InternalErrorShader;0;0;Standard;22;Surface;1;0;  Blend;0;0;Two Sided;1;0;Cast Shadows;0;0;  Use Shadow Threshold;0;0;Receive Shadows;0;0;GPU Instancing;0;0;LOD CrossFade;0;0;Built-in Fog;0;0;DOTS Instancing;0;0;Meta Pass;0;0;Extra Pre Pass;0;0;Tessellation;0;0;  Phong;0;0;  Strength;0.5,False,-1;0;  Type;0;0;  Tess;16,False,-1;0;  Min;10,False,-1;0;  Max;25,False,-1;0;  Edge Length;16,False,-1;0;  Max Displacement;25,False,-1;0;Vertex Position,InvertActionOnDeselection;1;0;0;5;False;True;False;True;False;False;;False;0
Node;AmplifyShaderEditor.TemplateMultiPassMasterNode;712;3791.423,-927.4819;Float;False;False;-1;2;UnityEditor.ShaderGraph.PBRMasterGUI;0;1;New Amplify Shader;2992e84f91cbeb14eab234972e07ea9d;True;DepthOnly;0;3;DepthOnly;0;False;False;False;False;False;False;False;False;False;False;False;False;True;0;False;-1;False;True;0;False;-1;False;False;False;False;False;False;False;False;False;True;False;255;False;-1;255;False;-1;255;False;-1;7;False;-1;1;False;-1;1;False;-1;1;False;-1;7;False;-1;1;False;-1;1;False;-1;1;False;-1;False;False;False;False;True;3;RenderPipeline=UniversalPipeline;RenderType=Opaque=RenderType;Queue=Geometry=Queue=0;True;0;True;17;d3d9;d3d11;glcore;gles;gles3;metal;vulkan;xbox360;xboxone;xboxseries;ps4;playstation;psp2;n3ds;wiiu;switch;nomrt;0;False;False;False;False;False;False;False;False;False;False;False;False;True;0;False;-1;False;False;False;True;False;False;False;False;0;False;-1;False;False;False;False;False;False;False;False;False;True;1;False;-1;False;False;True;1;LightMode=DepthOnly;False;False;0;Hidden/InternalErrorShader;0;0;Standard;0;False;0
WireConnection;531;0;528;3
WireConnection;531;1;528;4
WireConnection;533;0;528;1
WireConnection;532;0;528;2
WireConnection;535;1;51;0
WireConnection;535;3;528;1
WireConnection;535;4;528;2
WireConnection;534;0;533;0
WireConnection;534;1;532;0
WireConnection;536;0;51;0
WireConnection;536;1;531;0
WireConnection;538;0;535;0
WireConnection;538;2;531;0
WireConnection;537;0;51;0
WireConnection;537;1;534;0
WireConnection;537;2;536;0
WireConnection;539;0;537;0
WireConnection;539;1;538;0
WireConnection;539;2;540;0
WireConnection;530;0;529;1
WireConnection;530;1;529;2
WireConnection;394;0;393;0
WireConnection;53;0;539;0
WireConnection;53;2;530;0
WireConnection;395;0;53;0
WireConnection;395;2;394;0
WireConnection;663;0;395;0
WireConnection;665;0;663;1
WireConnection;664;0;663;0
WireConnection;573;1;561;0
WireConnection;574;0;561;0
WireConnection;574;1;573;0
WireConnection;574;2;540;0
WireConnection;666;0;664;0
WireConnection;666;1;665;0
WireConnection;560;0;559;0
WireConnection;667;1;395;0
WireConnection;667;0;666;0
WireConnection;562;0;574;0
WireConnection;562;2;560;0
WireConnection;564;1;562;0
WireConnection;50;1;667;0
WireConnection;567;0;564;1
WireConnection;567;1;50;1
WireConnection;502;0;499;3
WireConnection;502;1;499;4
WireConnection;504;0;499;1
WireConnection;682;0;564;1
WireConnection;682;1;50;1
WireConnection;503;0;499;2
WireConnection;509;0;57;0
WireConnection;509;1;502;0
WireConnection;505;0;504;0
WireConnection;505;1;503;0
WireConnection;506;1;57;0
WireConnection;506;3;499;1
WireConnection;506;4;499;2
WireConnection;683;1;567;0
WireConnection;683;0;682;0
WireConnection;677;0;679;0
WireConnection;508;0;57;0
WireConnection;508;1;505;0
WireConnection;508;2;509;0
WireConnection;70;0;683;0
WireConnection;507;0;506;0
WireConnection;507;2;502;0
WireConnection;678;0;677;0
WireConnection;316;0;305;0
WireConnection;242;0;241;1
WireConnection;242;1;241;2
WireConnection;501;0;500;1
WireConnection;501;1;500;2
WireConnection;511;0;508;0
WireConnection;511;1;507;0
WireConnection;511;2;510;0
WireConnection;433;0;431;3
WireConnection;433;1;431;4
WireConnection;42;0;39;1
WireConnection;42;1;39;2
WireConnection;311;0;310;0
WireConnection;58;0;511;0
WireConnection;58;2;501;0
WireConnection;680;0;304;0
WireConnection;680;1;302;0
WireConnection;434;0;431;1
WireConnection;435;0;431;2
WireConnection;59;0;433;0
WireConnection;59;1;42;0
WireConnection;59;2;60;0
WireConnection;285;0;242;0
WireConnection;307;0;314;0
WireConnection;307;1;303;2
WireConnection;307;2;317;0
WireConnection;436;0;434;0
WireConnection;436;1;435;0
WireConnection;681;0;58;0
WireConnection;681;1;680;0
WireConnection;443;1;35;0
WireConnection;443;3;431;1
WireConnection;443;4;431;2
WireConnection;43;0;35;0
WireConnection;43;1;59;0
WireConnection;449;0;433;0
WireConnection;449;1;42;0
WireConnection;449;2;60;0
WireConnection;430;0;35;0
WireConnection;430;1;436;0
WireConnection;430;2;43;0
WireConnection;481;0;478;3
WireConnection;481;1;478;4
WireConnection;75;0;74;3
WireConnection;75;1;74;4
WireConnection;446;0;443;0
WireConnection;446;2;449;0
WireConnection;309;0;681;0
WireConnection;309;1;306;0
WireConnection;309;2;307;0
WireConnection;474;0;481;0
WireConnection;474;1;75;0
WireConnection;474;2;73;0
WireConnection;609;0;430;0
WireConnection;609;1;446;0
WireConnection;609;2;610;0
WireConnection;487;0;483;2
WireConnection;486;0;483;3
WireConnection;486;1;483;4
WireConnection;475;0;478;2
WireConnection;476;0;478;1
WireConnection;92;0;309;0
WireConnection;488;0;483;1
WireConnection;360;0;55;0
WireConnection;440;0;439;1
WireConnection;440;1;439;2
WireConnection;489;0;488;0
WireConnection;489;1;487;0
WireConnection;477;1;77;0
WireConnection;477;3;478;1
WireConnection;477;4;478;2
WireConnection;469;0;77;0
WireConnection;469;1;474;0
WireConnection;385;0;384;0
WireConnection;473;0;476;0
WireConnection;473;1;475;0
WireConnection;674;0;676;0
WireConnection;471;0;481;0
WireConnection;471;1;75;0
WireConnection;471;2;73;0
WireConnection;497;1;217;0
WireConnection;497;3;483;1
WireConnection;497;4;483;2
WireConnection;36;0;609;0
WireConnection;36;2;440;0
WireConnection;491;0;217;0
WireConnection;491;1;486;0
WireConnection;67;0;360;0
WireConnection;675;0;674;0
WireConnection;472;0;477;0
WireConnection;472;2;471;0
WireConnection;470;0;77;0
WireConnection;470;1;473;0
WireConnection;470;2;469;0
WireConnection;496;0;497;0
WireConnection;496;2;486;0
WireConnection;386;0;93;0
WireConnection;386;2;385;0
WireConnection;571;1;418;0
WireConnection;493;0;217;0
WireConnection;493;1;489;0
WireConnection;493;2;491;0
WireConnection;161;0;36;0
WireConnection;485;0;484;1
WireConnection;485;1;484;2
WireConnection;467;0;470;0
WireConnection;467;1;472;0
WireConnection;467;2;468;0
WireConnection;652;0;386;0
WireConnection;480;0;479;1
WireConnection;480;1;479;2
WireConnection;353;0;71;0
WireConnection;353;1;72;0
WireConnection;495;0;493;0
WireConnection;495;1;496;0
WireConnection;495;2;494;0
WireConnection;416;0;415;0
WireConnection;568;0;418;0
WireConnection;568;1;571;0
WireConnection;568;2;510;0
WireConnection;354;0;162;0
WireConnection;354;1;353;0
WireConnection;322;0;321;0
WireConnection;322;1;323;0
WireConnection;417;0;568;0
WireConnection;417;2;416;0
WireConnection;99;0;313;0
WireConnection;99;1;100;2
WireConnection;99;2;318;0
WireConnection;653;0;652;1
WireConnection;654;0;652;0
WireConnection;216;0;495;0
WireConnection;216;2;485;0
WireConnection;79;0;467;0
WireConnection;79;2;480;0
WireConnection;378;0;380;0
WireConnection;283;0;354;0
WireConnection;283;1;284;0
WireConnection;283;2;99;0
WireConnection;319;0;79;0
WireConnection;319;1;322;0
WireConnection;546;0;544;3
WireConnection;546;1;544;4
WireConnection;688;0;684;2
WireConnection;388;0;387;0
WireConnection;320;0;322;0
WireConnection;320;1;216;0
WireConnection;391;0;390;0
WireConnection;548;0;544;2
WireConnection;686;0;684;3
WireConnection;686;1;684;4
WireConnection;547;0;544;1
WireConnection;687;0;684;1
WireConnection;412;1;417;0
WireConnection;655;0;654;0
WireConnection;655;1;653;0
WireConnection;550;0;547;0
WireConnection;550;1;548;0
WireConnection;389;0;320;0
WireConnection;389;2;388;0
WireConnection;656;1;386;0
WireConnection;656;0;655;0
WireConnection;392;0;319;0
WireConnection;392;2;391;0
WireConnection;277;0;412;1
WireConnection;690;0;685;0
WireConnection;690;1;686;0
WireConnection;691;0;687;0
WireConnection;691;1;688;0
WireConnection;549;1;173;0
WireConnection;549;3;544;1
WireConnection;549;4;544;2
WireConnection;551;0;173;0
WireConnection;551;1;546;0
WireConnection;377;0;283;0
WireConnection;377;2;378;0
WireConnection;689;1;685;0
WireConnection;689;3;684;1
WireConnection;689;4;684;2
WireConnection;632;0;377;0
WireConnection;554;0;549;0
WireConnection;554;2;546;0
WireConnection;693;0;685;0
WireConnection;693;1;691;0
WireConnection;693;2;690;0
WireConnection;692;0;689;0
WireConnection;692;2;686;0
WireConnection;647;0;389;0
WireConnection;553;0;173;0
WireConnection;553;1;550;0
WireConnection;553;2;551;0
WireConnection;642;0;392;0
WireConnection;714;0;49;1
WireConnection;23;1;656;0
WireConnection;556;0;553;0
WireConnection;556;1;554;0
WireConnection;556;2;552;0
WireConnection;648;0;647;1
WireConnection;698;0;694;1
WireConnection;698;1;694;2
WireConnection;557;0;555;1
WireConnection;557;1;555;2
WireConnection;634;0;632;1
WireConnection;351;0;136;0
WireConnection;351;1;352;0
WireConnection;280;0;281;0
WireConnection;280;1;23;1
WireConnection;633;0;632;0
WireConnection;649;0;647;0
WireConnection;643;0;642;1
WireConnection;644;0;642;0
WireConnection;697;0;693;0
WireConnection;697;1;692;0
WireConnection;697;2;695;0
WireConnection;62;0;29;0
WireConnection;62;1;714;0
WireConnection;62;2;61;0
WireConnection;168;0;556;0
WireConnection;168;2;557;0
WireConnection;635;0;633;0
WireConnection;635;1;634;0
WireConnection;700;0;697;0
WireConnection;700;2;698;0
WireConnection;30;0;62;0
WireConnection;30;1;31;0
WireConnection;650;0;649;0
WireConnection;650;1;648;0
WireConnection;645;0;644;0
WireConnection;645;1;643;0
WireConnection;699;0;696;0
WireConnection;397;0;396;0
WireConnection;24;0;280;0
WireConnection;24;1;25;0
WireConnection;139;0;351;0
WireConnection;139;4;137;0
WireConnection;139;2;135;0
WireConnection;139;3;138;0
WireConnection;334;0;333;0
WireConnection;140;0;139;0
WireConnection;651;1;389;0
WireConnection;651;0;650;0
WireConnection;701;0;700;0
WireConnection;701;2;699;0
WireConnection;398;0;168;0
WireConnection;398;2;397;0
WireConnection;97;1;98;0
WireConnection;97;0;96;0
WireConnection;636;1;377;0
WireConnection;636;0;635;0
WireConnection;646;1;392;0
WireConnection;646;0;645;0
WireConnection;26;0;24;0
WireConnection;26;1;30;0
WireConnection;8;1;646;0
WireConnection;327;0;97;0
WireConnection;1;1;636;0
WireConnection;34;0;33;0
WireConnection;658;0;398;0
WireConnection;45;0;26;0
WireConnection;702;0;701;0
WireConnection;141;0;140;0
WireConnection;218;1;651;0
WireConnection;130;0;280;0
WireConnection;704;0;702;0
WireConnection;606;1;8;4
WireConnection;606;0;8;1
WireConnection;105;0;62;0
WireConnection;105;1;130;0
WireConnection;144;0;140;0
WireConnection;144;1;141;0
WireConnection;144;2;142;0
WireConnection;660;0;658;1
WireConnection;336;0;97;0
WireConnection;336;1;327;0
WireConnection;336;2;337;0
WireConnection;703;0;702;1
WireConnection;608;1;218;4
WireConnection;608;0;218;1
WireConnection;32;0;45;0
WireConnection;32;1;34;0
WireConnection;32;2;33;0
WireConnection;599;1;1;4
WireConnection;599;0;1;1
WireConnection;659;0;658;0
WireConnection;705;0;704;0
WireConnection;705;1;703;0
WireConnection;220;0;606;0
WireConnection;220;1;608;0
WireConnection;122;0;32;0
WireConnection;124;0;105;0
WireConnection;126;0;336;0
WireConnection;661;0;659;0
WireConnection;661;1;660;0
WireConnection;147;0;144;0
WireConnection;372;0;599;0
WireConnection;372;1;365;0
WireConnection;82;0;220;0
WireConnection;662;1;398;0
WireConnection;662;0;661;0
WireConnection;373;0;372;0
WireConnection;373;1;370;0
WireConnection;706;1;701;0
WireConnection;706;0;705;0
WireConnection;707;1;706;0
WireConnection;169;1;662;0
WireConnection;374;0;599;0
WireConnection;374;1;373;0
WireConnection;374;2;367;0
WireConnection;176;0;178;0
WireConnection;176;1;167;4
WireConnection;176;2;179;0
WireConnection;338;0;128;0
WireConnection;338;2;340;0
WireConnection;615;1;209;0
WireConnection;615;0;150;0
WireConnection;413;0;123;0
WireConnection;413;1;125;0
WireConnection;413;2;414;0
WireConnection;6;0;374;0
WireConnection;6;1;3;4
WireConnection;6;2;4;4
WireConnection;6;3;413;0
WireConnection;6;4;95;0
WireConnection;6;5;338;0
WireConnection;6;6;221;0
WireConnection;6;7;615;0
WireConnection;171;0;169;1
WireConnection;171;1;172;0
WireConnection;171;2;175;0
WireConnection;171;3;176;0
WireConnection;171;4;707;1
WireConnection;181;0;171;0
WireConnection;616;0;6;0
WireConnection;585;0;583;0
WireConnection;585;1;584;0
WireConnection;585;2;586;0
WireConnection;460;1;226;0
WireConnection;460;3;459;1
WireConnection;460;4;459;2
WireConnection;641;1;383;0
WireConnection;641;0;640;0
WireConnection;383;0;235;0
WireConnection;383;2;382;0
WireConnection;576;1;186;0
WireConnection;576;3;575;1
WireConnection;576;4;575;2
WireConnection;589;0;188;0
WireConnection;589;2;590;0
WireConnection;107;0;109;0
WireConnection;107;1;130;0
WireConnection;587;0;577;0
WireConnection;587;1;578;0
WireConnection;109;0;62;0
WireConnection;109;1;106;0
WireConnection;454;0;455;0
WireConnection;454;1;456;0
WireConnection;582;0;186;0
WireConnection;582;1;579;0
WireConnection;359;0;4;0
WireConnection;359;1;357;0
WireConnection;359;2;358;0
WireConnection;584;0;576;0
WireConnection;584;2;579;0
WireConnection;637;0;383;0
WireConnection;579;0;575;3
WireConnection;579;1;575;4
WireConnection;668;0;589;0
WireConnection;231;0;229;0
WireConnection;193;0;192;0
WireConnection;193;1;194;3
WireConnection;193;2;195;0
WireConnection;455;0;459;1
WireConnection;670;0;668;1
WireConnection;639;0;637;0
WireConnection;456;0;459;2
WireConnection;638;0;637;1
WireConnection;716;1;212;0
WireConnection;716;0;212;1
WireConnection;669;0;668;0
WireConnection;457;0;459;3
WireConnection;457;1;459;4
WireConnection;614;1;131;0
WireConnection;614;0;199;0
WireConnection;640;0;639;0
WireConnection;640;1;638;0
WireConnection;191;0;201;0
WireConnection;191;1;193;0
WireConnection;203;0;190;1
WireConnection;203;1;191;0
WireConnection;611;0;453;0
WireConnection;611;1;461;0
WireConnection;611;2;612;0
WireConnection;583;0;186;0
WireConnection;583;1;587;0
WireConnection;583;2;582;0
WireConnection;671;0;669;0
WireConnection;671;1;670;0
WireConnection;330;1;332;0
WireConnection;330;2;335;0
WireConnection;577;0;575;1
WireConnection;190;1;672;0
WireConnection;603;1;211;0
WireConnection;603;0;605;0
WireConnection;183;0;185;0
WireConnection;329;0;341;0
WireConnection;329;1;603;0
WireConnection;672;1;589;0
WireConnection;672;0;671;0
WireConnection;345;0;330;0
WireConnection;345;1;346;0
WireConnection;580;0;581;1
WireConnection;580;1;581;2
WireConnection;5;0;329;0
WireConnection;5;1;3;0
WireConnection;5;2;356;0
WireConnection;5;3;94;0
WireConnection;5;4;615;0
WireConnection;5;5;374;0
WireConnection;5;6;8;0
WireConnection;108;0;105;0
WireConnection;108;1;107;0
WireConnection;131;0;5;0
WireConnection;131;1;132;0
WireConnection;131;2;134;0
WireConnection;185;0;202;0
WireConnection;185;1;203;0
WireConnection;196;0;183;0
WireConnection;578;0;575;2
WireConnection;356;0;4;0
WireConnection;356;1;359;0
WireConnection;382;0;381;0
WireConnection;590;0;591;0
WireConnection;458;0;226;0
WireConnection;458;1;457;0
WireConnection;133;0;108;0
WireConnection;464;0;463;1
WireConnection;464;1;463;2
WireConnection;188;0;585;0
WireConnection;188;2;580;0
WireConnection;461;0;460;0
WireConnection;461;2;457;0
WireConnection;453;0;226;0
WireConnection;453;1;454;0
WireConnection;453;2;458;0
WireConnection;229;0;611;0
WireConnection;229;2;464;0
WireConnection;717;0;716;0
WireConnection;717;1;718;0
WireConnection;235;0;234;0
WireConnection;235;1;232;0
WireConnection;235;2;233;0
WireConnection;212;1;641;0
WireConnection;341;0;343;0
WireConnection;341;1;345;0
WireConnection;605;0;1;0
WireConnection;605;1;717;0
WireConnection;211;0;1;0
WireConnection;211;1;717;0
WireConnection;211;2;213;0
WireConnection;617;1;6;0
WireConnection;617;0;616;0
WireConnection;710;2;131;0
WireConnection;710;3;617;0
WireConnection;710;5;182;0
ASEEND*/
//CHKSM=450D2F41D29A074952713641509264C2C82B6906