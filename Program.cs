using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Xml.Serialization;
using static MaaametApi.MaaAmetApiResponse;

namespace MaaametApi
{
    class Program
    {

        //https://www.surinderbhomra.com/Blog/2016/05/18/Useful-Method-To-Deserialize-XML-or-JSON-To-A-Class-Object
        static void Main(string[] args)
        {

            var result = ApiWebRequestHelper.GetXmlRequest<Tulem>("https://xgis.maaamet.ee/adsavalik/adsobjektid?x=6574584.4&y=671550.8&ulatus=450&liik=AY");
            //Console.WriteLine(result);

            foreach (var item in result.Objektid.Objekt)
            {
                Console.WriteLine(item.Aadressid.Aadress.TaisAadress);
                //Console.WriteLine(item.Aadressid.Aadress.AdsTase3.Nimetus);
            }
        }
        
    }    
}
