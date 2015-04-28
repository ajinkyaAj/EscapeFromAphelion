     Shader "Custom/GlowShader" {
    Properties {
    _MainTex ("Base (RGB)", 2D) = "white" {}
    /// _Color ("Main Color", Color) = (1,1,1,0)
    _Inflate("Infalate", Float) = 0.5
    _GlowColor ("Glow Color", Color) = (1,1,1,0.5)
    _GlowExpon ("GlowExpon", Range(1.0, 7.0)) = 0.1
    }
    SubShader {
    Tags { "RenderType"="Opaque" }
    //LOD 200
    Tags { "Queue" = "Transparent" }
    Pass {
    Blend One One
    SetTexture [_MainTex] { combine texture, texture}
    }
    Pass {
    // Blend One One
    Blend SrcAlpha OneMinusSrcAlpha
    // Blend DstColor Zero
    CGPROGRAM
    #include "UnityCG.cginc"
    #pragma vertex vert
    #pragma fragment frag
    sampler2D _MainTex;
    uniform float _Inflate;
    uniform float4x4 ViewIXf;
    uniform float4 _GlowColor;
    uniform float _GlowExpon;
    struct appdata {
    float4 vertex : POSITION;
    float4 UV:TEXCOORD0;
    float4 Normal :NORMAL;
    float4 Tangent :TANGENT;
    // float4 Binormal :BINORMAL0;
    };
    struct gloVertOut {
    float4 HPosition : SV_POSITION;
    float3 WorldNormal : TEXCOORD0;
    float3 WorldView : TEXCOORD1;
    };
    gloVertOut vert (appdata IN) {
    gloVertOut OUT = (gloVertOut)0;
    OUT.WorldNormal = mul(UNITY_MATRIX_IT_MV,IN.Normal).xyz;/////UNITY_MATRIX_IT_MV =WorldITXf
    float4 Po = float4(IN.vertex.xyz,1);
    Po += (_Inflate*normalize(float4(IN.Normal.xyz,0))); // the balloon effect
    float4 Pw = mul(_Object2World,Po);///_Object2World =WorldXf
    OUT.WorldView = normalize(float3(ViewIXf[0].w,ViewIXf[1].w,ViewIXf[2].w) - Pw.xyz);///ViewIXf=ViewInverse
    OUT.HPosition = mul(UNITY_MATRIX_MVP ,Po);//WvpXf=UNITY_MATRIX_MVP
    return OUT;
    }
    float4 frag( gloVertOut IN ) : COLOR {
    float3 Nn = normalize(IN.WorldNormal);
    float3 Vn = normalize(IN.WorldView);
    float edge = 1.0 - dot(Nn,Vn);
    edge = pow(edge,_GlowExpon);
    float3 result = edge * _GlowColor.rgb;
    float4 texcol= tex2D (_MainTex, IN.WorldView);
    return float4(result,edge);
    //float4 res=float4(result,edge);
    // return texcol*res;
    }
    ENDCG
    }
    }
    }
     
