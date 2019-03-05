//UVic CSC 305, 2019 Spring
//
//Helping lab for assignment02

Shader "Unlit/simpleShader"
{
	Properties
	{
		_MainTex("Texture", 2D) = "white" {}
	}

		SubShader
		{
			Tags { "RenderType" = "Opaque"
			"LightMode" = "ForwardBase" }
			LOD 100

			Pass
			{
				CGPROGRAM
				#pragma vertex vert
				#pragma fragment frag

				#include "UnityCG.cginc"
				#include "Lighting.cginc"

				struct appdata
				{
					float4 vertex : POSITION;
					float2 uv : TEXCOORD0;
					float3 normal : NORMAL;

				};

				struct v2f
				{
					float2 uv : TEXCOORD0;
					float height : TEXCOORD1;
					float3 normal : TEXCOORD2;
					float4 worldpos : TEXCOORD3;
					float4 vertex : SV_POSITION;

				};

				sampler2D _MainTex;
				float4 _MainTex_ST;

				v2f vert(appdata v)
				{
					v2f o;
					o.vertex = UnityObjectToClipPos(v.vertex);
					o.height = v.vertex.y;
					o.uv = TRANSFORM_TEX(v.uv, _MainTex);
					o.normal = UnityObjectToWorldNormal(v.normal);
					o.worldpos = mul(unity_ObjectToWorld, v.vertex);
					return o;
				}

				float4 frag(v2f i) : SV_Target
				{

					float4 fragment_color = float4(0,0,0,0);
					if (i.height < 1) fragment_color = float4(1,0,0,0);
					else if (i.height < 2) fragment_color = float4(0,1,0,0);
					else if (i.height < 3) fragment_color = tex2D(_MainTex, i.uv);//float4(0,0,1,0);
					else fragment_color = float4(1,1,0,0);

					return fragment_color;
				}
				ENDCG
			}
		}
}
