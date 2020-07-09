using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.logistics.redefining.querytrackingresult
    /// </summary>
    public class AliexpressLogisticsRedefiningQuerytrackingresultRequest : BaseTopRequest<Top.Api.Response.AliexpressLogisticsRedefiningQuerytrackingresultResponse>
    {
        /// <summary>
        /// Logistics tracking number
        /// </summary>
        public string LogisticsNo { get; set; }

        /// <summary>
        /// Order origin to be queried. The origin of the AE order is “ESCROW”.
        /// </summary>
        public string Origin { get; set; }

        /// <summary>
        /// Order ID to be queried by the user
        /// </summary>
        public string OutRef { get; set; }

        /// <summary>
        /// Logistics service KEY
        /// </summary>
        public string ServiceName { get; set; }

        /// <summary>
        /// Country for receiving goods in the trade order (FJ,Fiji;FI,Finland;FR,France;FX,FranceMetropolitan;GF,FrenchGuiana;PF,FrenchPolynesia;TF,FrenchSouthernTerritories;GA,Gabon;GM,Gambia;GE,Georgia;DE,Germany;GH,Ghana;GI,Gibraltar;GR,Greece;GL,Greenland;GD,Grenada;GP,Guadeloupe;GU,Guam;GT,Guatemala;GN,Guinea;GW,Guinea-Bissau;GY,Guyana;HT,Haiti;HM,HeardandMcDonaldIslands;HN,Honduras;HK,HongKong;HU,Hungary;IS,Iceland;IN,India;ID,Indonesia;IR,Iran(IslamicRepublicof);IQ,Iraq;IE,Ireland;IL,Israel;IT,Italy;JM,Jamaica;JP,Japan;JO,Jordan;KZ,Kazakhstan;KE,Kenya;KI,Kiribati;KW,Kuwait;KG,Kyrgyzstan;LA,LaoPeople'sDemocraticRepublic;LV,Latvia;LB,Lebanon;LS,Lesotho;LR,Liberia;LY,LibyanArabJamahiriya;AF,Afghanistan;AL,Albania;DZ,Algeria;AS,AmericanSamoa;AD,Andorra;AO,Angola;AI,Anguilla;AQ,Antarctica;AG,AntiguaandBarbuda;AR,Argentina;AM,Armenia;AW,Aruba;AU,Australia;AT,Austria;AZ,Azerbaijan;BS,Bahamas;BH,Bahrain;BD,Bangladesh;BB,Barbados;BY,Belarus;BE,Belgium;BZ,Belize;BJ,Benin;BM,Bermuda;BT,Bhutan;BO,Bolivia;BA,BosniaandHerzegovina;BW,Botswana;BV,BouvetIsland;BR,Brazil;IO,BritishIndianOceanTerritory;BN,BruneiDarussalam;BG,Bulgaria;BF,BurkinaFaso;BI,Burundi;KH,Cambodia;CM,Cameroon;CA,Canada;CV,CapeVerde;KY,CaymanIslands;CF,CentralAfricanRepublic;TD,Chad;CL,Chile;CN,China(Mainland);CX,ChristmasIsland;CC,Cocos(Keeling)Islands;CO,Colombia;KM,Comoros;CG,Congo,TheRepublicofCongo;ZR,Congo,TheDemocraticRepublicOfThe;CK,CookIslands;CR,CostaRica;CI,CoteD'Ivoire;HR,Croatia(localname:Hrvatska);CU,Cuba;CY,Cyprus;CZ,CzechRepublic;DK,Denmark;DJ,Djibouti;DM,Dominica;DO,DominicanRepublic;TP,EastTimor;EC,Ecuador;EG,Egypt;SV,ElSalvador;GQ,EquatorialGuinea;ER,Eritrea;EE,Estonia;ET,Ethiopia;FK,FalklandIslands(Malvinas);FO,FaroeIslands;LI,Liechtenstein;LT,Lithuania;LU,Luxembourg;MO,Macau;MK,Macedonia;MG,Madagascar;MW,Malawi;MY,Malaysia;MV,Maldives;ML,Mali;MT,Malta;MH,MarshallIslands;MQ,Martinique;MR,Mauritania;MU,Mauritius;YT,Mayotte;MX,Mexico;FM,Micronesia;MD,Moldova;MC,Monaco;MN,Mongolia;MS,Montserrat;MA,Morocco;MZ,Mozambique;MM,Myanmar;NA,Namibia;NR,Nauru;NP,Nepal;NL,Netherlands;AN,NetherlandsAntilles;NC,NewCaledonia;NZ,NewZealand;NI,Nicaragua;NE,Niger;NG,Nigeria;NU,Niue;NF,NorfolkIsland;KP,NorthKorea;MP,NorthernMarianaIslands;NO,Norway;OM,Oman;Other,OtherCountry;PK,Pakistan;PW,Palau;PS,Palestine;PA,Panama;PG,PapuaNewGuinea;PY,Paraguay;PE,Peru;PH,Philippines;PN,Pitcairn;PL,Poland;PT,Portugal;PR,PuertoRico;QA,Qatar;RE,Reunion;RO,Romania;RU,RussianFederation;RW,Rwanda;KN,SaintKittsandNevis;LC,SaintLucia;VC,SaintVincentandtheGrenadines;WS,Samoa;SM,SanMarino;ST,SaoTomeandPrincipe;SA,SaudiArabia;SN,Senegal;SC,Seychelles;SL,SierraLeone;SG,Singapore;SK,Slovakia(SlovakRepublic);SI,Slovenia;SB,SolomonIslands;SO,Somalia;ZA,SouthAfrica;KR,SouthKorea;ES,Spain;LK,SriLanka;SH,St.Helena;PM,St.PierreandMiquelon;SD,Sudan;SR,Suriname;SJ,SvalbardandJanMayenIslands;SZ,Swaziland;SE,Sweden;CH,Switzerland;SY,SyrianArabRepublic;TW,T aiwan;TJ,Tajikistan;TZ,Tanzania;TH,Thailand;TG,Togo;TK,Tokelau;TO,Tonga;TT,TrinidadandTobago;TN,Tunisia;TR,Turkey;TM,Turkmenistan;TC,TurksandCaicosIslands;TV,Tuvalu;UG,Uganda;UA,Ukraine;AE,UnitedArabEmirates;IM,IsleofMan;UK,UnitedKingdom;US,UnitedStates;UM,UnitedStatesMinorOutlyingIslands;UY,Uruguay;UZ,Uzbekistan;VU,Vanuatu;VA,VaticanCityState(HolySee);VE,Venezuela;VN,Vietnam;VG,VirginIslands(British);VI,VirginIslands(U.S.);WF,WallisAndFutunaIslands;EH,WesternSahara;YE,Yemen;YU,Yugoslavia;ZM,Zambia;ZW,Zimbabwe;SRB,Serbia;MNE,Montenegro;KS,Kosovo;EAZ,Zanzibar;BLM,SaintBarthelemy;MAF,SaintMartin;GGY,Guernsey;JEY,Jersey;SGS,SouthGeorgiaandtheSouthSandwichIslands;TLS,Timor-Leste;ALA,AlandIslands;GBA,Alderney;ASC,AscensionIsland;)
        /// </summary>
        public string ToArea { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.logistics.redefining.querytrackingresult";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("logistics_no", this.LogisticsNo);
            parameters.Add("origin", this.Origin);
            parameters.Add("out_ref", this.OutRef);
            parameters.Add("service_name", this.ServiceName);
            parameters.Add("to_area", this.ToArea);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("logistics_no", this.LogisticsNo);
            RequestValidator.ValidateRequired("origin", this.Origin);
            RequestValidator.ValidateRequired("out_ref", this.OutRef);
            RequestValidator.ValidateRequired("service_name", this.ServiceName);
            RequestValidator.ValidateRequired("to_area", this.ToArea);
        }

        #endregion
    }
}
