/*
* @author   TCS
* @version  MSO Version 1.0
* @since    07 May 2015
*
* Modification History:
*
* Issue Id			Date of Modification		Modified By				Changes Made
******************************************************************************************************************** 
SR#2015-05-05-0922     07 May 2015           Anurag Agarwal         Trade compliance section modification

 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Data;


namespace Dal
{
    public class Common
    {
        //public enum MasterItemTypeID
        //{
        //    [Description("Requestor must indicate")]
        //    Requestormustindicate = 1,
        //    [Description("Reason for  shipment")]
        //    Reasonforshipment,
        //    [Description("Trade")]
        //    Trade,
        //    [Description("Bill freight")]
        //    Billfreight
        //}

        //public static List<InternationalDomestic> InternationalDomesticList(DataTable dtInternationalDomesticList)
        //{
        //    return InternationalDomesticList(dtInternationalDomesticList, null, null);
        //}

        //public static List<InternationalDomestic> InternationalDomesticList(DataTable dtInternationalDomesticList, DataTable dtSdsList, DataTable dtAssetList)
        //{
        //    List<InternationalDomestic> internationalDomestics = null;
        //    if (dtInternationalDomesticList != null)
        //    {
        //        internationalDomestics = GetInternationalDomestics(dtInternationalDomesticList.Select(), dtSdsList, dtAssetList);
        //    }
        //    return internationalDomestics;
        //}
      

        //public static List<InternationalDomestic> GetInternationalDomestics(DataRow[] rows)
        //{
        //    return GetInternationalDomestics(rows, null, null);
        //}

        //public static List<InternationalDomestic> GetInternationalDomestics(DataRow[] rows, DataTable dtSdsList, DataTable dtAssetList)
        //{
        //    List<InternationalDomestic> InternationalDomesticList = new List<InternationalDomestic>();
           
        //    if (rows.Length > 0)
        //    {
        //        foreach (DataRow row in rows)
        //        {
        //            InternationalDomesticList.Add(MakeInternationalDomestic(row, dtSdsList, dtAssetList));
        //        }
        //    }
        //    return InternationalDomesticList;
        //}

        //private static InternationalDomestic MakeInternationalDomestic(DataRow row, DataTable dtSdsList, DataTable dtAssetList)
        //{
        //    InternationalDomestic objinternationalDomesticList = new InternationalDomestic();
        //    objinternationalDomesticList.DomesticInternational = Utility.ReplaceNull<int>(row, "International_Domestic", 0);
        //    objinternationalDomesticList.ECCN = Utility.ReplaceNull<string>(row, "ECCN", "");
        //    objinternationalDomesticList.ExportControlled = Utility.ReplaceNull<int>(row, "Export_Controlled", 0);
        //    objinternationalDomesticList.CountryOfOrigin = Utility.ReplaceNull<string>(row, "Country_Of_Origin", "");
        //    objinternationalDomesticList.ExportEndUse = Utility.ReplaceNull<string>(row, "Export_End_Use", " ");
        //    objinternationalDomesticList.ItemId = Utility.ReplaceNull<int>(row, "Item_Id", 0);
        //    objinternationalDomesticList.ItemNumber = Utility.ReplaceNull<int>(row, "Item_Number", 0);
        //    objinternationalDomesticList.QuantityShipping = Utility.ReplaceNull<decimal?>(row, "Quantity_Shipping", 0);
        //    objinternationalDomesticList.MetalWeight = Utility.ReplaceNull<decimal>(row, "Metal_Weight", 0);
        //    objinternationalDomesticList.Description = Utility.ReplaceNull<string>(row, "Description", " ");
        //    objinternationalDomesticList.UnitPrice = Utility.ReplaceNull<decimal>(row, "Unit_Price", 0);
        //    objinternationalDomesticList.TotalValue = Utility.ReplaceNull<decimal>(row, "Total_Value", 0);
        //    objinternationalDomesticList.HTS = Utility.ReplaceNull<Int64>(row, "HTS", 0);
        //    objinternationalDomesticList.ITAR = Utility.ReplaceNull<int>(row, "ITAR", 0);
        //    objinternationalDomesticList.OshaAndEnvrionmentalInfo = MakeOshaAndEnvironmental(row, dtSdsList, dtAssetList);
        //    return objinternationalDomesticList;
        //}

        //private static OshaAndEnvrionmental MakeOshaAndEnvironmental(DataRow row, DataTable dtSdsList, DataTable dtAssetList)
        //{
        //    OshaAndEnvrionmental objOshaAndEnvironmental = new OshaAndEnvrionmental();
        //    objOshaAndEnvironmental.HasSafetyData = Utility.ReplaceNull<int>(row, "Has_Safety_Data", 0);
        //    objOshaAndEnvironmental.AlcoaProductWarningLabel = Utility.ReplaceNull<int>(row, "Alcoa_Product_Warning_Label", 0);
        //    objOshaAndEnvironmental.VendorProductWarningLabel = Utility.ReplaceNull<int>(row, "Vendor_Product_Warning_Label", 0);
        //    objOshaAndEnvironmental.OilHydraulic = Utility.ReplaceNull<int>(row, "Oil_Hydraulic", 0);
        //    objOshaAndEnvironmental.PPM = Utility.ReplaceNull<string>(row, "PPM", "");
        //    objOshaAndEnvironmental.AnalysisDate = Utility.ReplaceNull<DateTime>(row, "Analysis_Date", System.DateTime.MinValue);
        //    objOshaAndEnvironmental.TransformerCapacitorOrBallasts = Utility.ReplaceNull<int>(row, "Transformer_Capacitor_Or_Ballasts", 0);
        //    objOshaAndEnvironmental.ContainAsbestos = Utility.ReplaceNull<int>(row, "Contain_Asbestos", 0);
        //    objOshaAndEnvironmental.EPATSCA = Utility.ReplaceNull<int>(row, "EPA_TSCA", 0);
        //    objOshaAndEnvironmental.PackingOrComponent = Utility.ReplaceNull<int>(row, "Packing_Or_Component", 0);
        //    objOshaAndEnvironmental.ConegCertification = Utility.ReplaceNull<int>(row, "Coneg_Certification", 0);
        //    objOshaAndEnvironmental.IsAssetnumber = Utility.ReplaceNull<int>(row, "IsAsset_Number", 0);
        //    objOshaAndEnvironmental.Rsm = Utility.ReplaceNull<int>(row, "Radioactive_Source_Material", 0);
        //    objOshaAndEnvironmental.ItemId = Utility.ReplaceNull<int>(row, "Item_Id", 0);
        //    objOshaAndEnvironmental.AlcoaSDS = AlcoaSDSList(dtSdsList, objOshaAndEnvironmental.ItemId);
        //    objOshaAndEnvironmental.AssetNumberList = AssetNumberList(dtAssetList, objOshaAndEnvironmental.ItemId);
        //    return objOshaAndEnvironmental;
        //}

        //public static List<AlcoaSDS> AlcoaSDSList(DataTable dtSdsList)
        //{
        //    return AlcoaSDSList(dtSdsList, 0);
        //}

        //public static List<AlcoaSDS> AlcoaSDSList(DataTable dtSdsList, int itemId)
        //{
        //    List<AlcoaSDS> alcoaSds = null;
        //    if (dtSdsList != null)
        //    {
        //        string query = string.Format("Item_Id_Fk = {0}" , itemId);
        //        DataRow[] datarow = dtSdsList.Select(query);
        //        alcoaSds = GetAlcoaSDSs(datarow);
        //    }
        //    return alcoaSds;
        //}
              

        //public static List<AlcoaSDS> GetAlcoaSDSs(DataRow[] rows)
        //{
        //    List<AlcoaSDS> AlcoaSDSList = new List<AlcoaSDS>();
        //    if (rows.Length > 0)
        //    {
        //        foreach (DataRow row in rows)
        //        {
        //            AlcoaSDSList.Add(MakeAlcoaNumberObject(row));
        //        }
        //    }
        //    return AlcoaSDSList;
        //}

        //private static AlcoaSDS MakeAlcoaNumberObject(DataRow row)
        //{
        //    AlcoaSDS objAlcoaSDS = new AlcoaSDS();
        //    objAlcoaSDS.MsoIdFK = Utility.ReplaceNull<int>(row, "MSO_No_ID_Fk", 0);
        //    objAlcoaSDS.AlcoaSDSNo = Utility.ReplaceNull<Int64?>(row, "Alcoa_SDS_No", 0);
        //    objAlcoaSDS.ItemIdFk = Utility.ReplaceNull<int>(row, "Item_Id_Fk", 0);
        //    return objAlcoaSDS;
        //}

        //public static List<AssetNumber> AssetNumberList(DataTable dtaAssetList)
        //{
        //    return AssetNumberList(dtaAssetList, 0);
        //}

        //public static List<AssetNumber> AssetNumberList(DataTable dtaAssetList , int itemId)
        //{
        //    List<AssetNumber> assetNumber = null;
        //    if (dtaAssetList != null)
        //    {
        //        string query = string.Format("Item_Id_Fk = {0}", itemId);
        //        DataRow[] datarow = dtaAssetList.Select(query);
        //        assetNumber = GetAssetNumber(datarow);
        //    }
        //    return assetNumber;
        //}

        //public static List<AssetNumber> GetAssetNumber(DataRow[] rows)
        //{
        //    List<AssetNumber> AssetNumberList = new List<AssetNumber>();
        //    if (rows.Length > 0)
        //    {
        //        foreach (DataRow row in rows)
        //        {
        //            AssetNumberList.Add(MakeAssetNumberObject(row));
        //        }
        //    }
        //    return AssetNumberList;
        //}

        //private static AssetNumber MakeAssetNumberObject(DataRow row)
        //{
        //    AssetNumber objAssetNumber = new AssetNumber();
        //    objAssetNumber.MsoIdFK = Utility.ReplaceNull<int>(row, "MSO_No_ID_Fk", 0);
        //    objAssetNumber.AssetNumberNo = Utility.ReplaceNull<string>(row, "Asset_No", "");
        //    objAssetNumber.ItemIdFk = Utility.ReplaceNull<int>(row, "Item_Id_Fk", 0);
        //    return objAssetNumber;
        //}

        //public static OracleParameter GetOracleParameter(string name, object value, ParameterDirection? direction, OracleType? type)
        //{
        //    return GetOracleParameter(name, value, direction, type, null);
        //}

        //public static OracleParameter GetOracleParameter(string name, object value, ParameterDirection? direction, OracleType? type, int? size)
        //{
        //    OracleParameter param = new OracleParameter();
        //    param.ParameterName = name;
        //    if (value != null)
        //        param.Value = value;
        //    if (direction != null)
        //        param.Direction = (ParameterDirection)direction;
        //    if (type != null)
        //        param.OracleType = (OracleType)type;
        //    if (size != null)
        //        param.Size = (int)size;
        //    return param;
        //}

        ///// <summary>
        ///// This method returns certain mso details that are
        ///// commonly required at multiple places
        ///// </summary>
        ///// <param name="ds">
        ///// recieves dataset as the parameter
        ///// </param>
        ///// <returns>
        ///// returns msodetails object
        ///// </returns>
        //public static MSODetails GetCommonlyUsedMsoDetails(DataSet ds)
        //{
        //    MSODetails msoDetail = new MSODetails();
        //    if (ds.Tables[0].Rows.Count > 0)
        //    {
        //        foreach (DataRow row in ds.Tables[0].Rows)
        //        {
        //            msoDetail.MsoNumber = Utility.ReplaceNull<string>(row, "MSO_Number", "");
        //            msoDetail.PurchaseOrderNo = Utility.ReplaceNull<string>(row, "Purcahse_Order_No", "");
        //            msoDetail.Department = Utility.ReplaceNull<string>(row, "Department", "");
        //            msoDetail.RequestedBy = Utility.ReplaceNull<string>(row, "Requested_By", "");
        //            msoDetail.Ext = Utility.ReplaceNull<string>(row, "Ext", "");
        //            msoDetail.SubmittedBy = Utility.ReplaceNull<string>(row, "Submitted_By", "");
        //        }
        //    }
        //    return msoDetail;
        //}
    }
}
