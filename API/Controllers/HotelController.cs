using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Wizcation.DBHelpers;
using System.Data.Entity;
using API.ViewModel;

namespace API.Controllers
{
    public class HotelController : BaseController
    {
        //private static string szDbUser = "wiz";
        //private static string szDbPassword = "w!zc@t!0n";

        //[HttpGet]
        ////// GET: Application/ApiAds
        //public HttpResponseMessage GetAllHotel()
        //{
        //    try
        //    {
        //        string sql = "SELECT TOP 1000 [wizcation_db].[dbo].[agent _data].[AgentID]"
        //          + ",[AgentType]"
        //          + ",[AgentName]"
        //          + ",[AgentAddress1]"
        //          + ",[AgentAddress2]"
        //          + ",[AgentCity]"
        //          + ",[AgentProvince]"
        //          + ",[AgentZipCode]"
        //          + ",[AgentContactName]"
        //          + ",[AgentMobile]"
        //          + ",[AgentTelephone]"
        //          + ",[AgentFax]"
        //          + ",[AgentEmail]"
        //          + ",[AgentPictureServer]"
        //          + ",[AgentPictureClient]"
        //          + ",[Latitude]"
        //          + ",[Longitude]"
        //          + ",[PropertiesCatergory]"
        //          + ",[PropertiesAmenities]"
        //          + "  FROM [wizcation_db].[dbo].[agent _data]"
        //          + "  INNER JOIN[wizcation_db].[dbo].[properties_data]"
        //          + "  ON[wizcation_db].[dbo].[agent _data].[AgentID]=[wizcation_db].[dbo].[properties_data].[AgentID];";

        //        string errMsg = "";
        //        SqlConnection conn = DBHelper.ConnectDb(ref errMsg);
        //        DataTable listHotel = DBHelper.List(sql, conn);
        //        conn.Close();
        //        return Request.CreateResponse(HttpStatusCode.OK, new { Result = listHotel, Message = "Successfully", Status = true });
        //    }
        //    catch (Exception ex)
        //    {

        //        return Request.CreateResponse(HttpStatusCode.OK, new { Result = ex.Message, Message = "Exception", Status = false });
        //    }
        //}

        //public HttpResponseMessage Detail(int hotelID)
        //{
        //    try
        //    {
        //        string sql = "SELECT TOP 1000 [wizcation_db].[dbo].[agent _data].[AgentID]"
        //         + ",[AgentType]"
        //         + ",[AgentName]"
        //         + ",[AgentAddress1]"
        //         + ",[AgentAddress2]"
        //         + ",[AgentCity]"
        //         + ",[AgentProvince]"
        //         + ",[AgentZipCode]"
        //         + ",[AgentContactName]"
        //         + ",[AgentMobile]"
        //         + ",[AgentTelephone]"
        //         + ",[AgentFax]"
        //         + ",[AgentEmail]"
        //         + ",[AgentPictureServer]"
        //         + ",[AgentPictureClient]"
        //         + ",[Latitude]"
        //         + ",[Longitude]"
        //         + ",[PropertiesCatergory]"
        //         + ",[PropertiesAmenities]"
        //         + "  FROM [wizcation_db].[dbo].[agent _data]"
        //         + "  INNER JOIN[wizcation_db].[dbo].[properties_data]"
        //         + "  ON[wizcation_db].[dbo].[agent _data].[AgentID]=[wizcation_db].[dbo].[properties_data].[AgentID];";


        //        string connStrFmt = "Data Source={0}; Initial Catalog={1};User ID={2}; Password={3}";
        //        string connString = string.Format(connStrFmt, ConfigurationManager.AppSettings["DBServer"], ConfigurationManager.AppSettings["DBName"], szDbUser, szDbPassword);

        //        var conn = new SqlConnection(connString);
        //        conn.Open();

        //        SqlCommand command = new SqlCommand(sql, conn);
        //        // int result = command.ExecuteNonQuery(); 
        //        SqlDataReader reader = command.ExecuteReader();
        //        conn.Close();

        //        return Request.CreateResponse(HttpStatusCode.OK, new { Result = reader, Message = "Successfully", Status = true });
        //    }
        //    catch (Exception ex)
        //    {

        //        return Request.CreateResponse(HttpStatusCode.OK, new { Result = ex.Message, Message = "Exception", Status = false });

        //    }
        //}

        [System.Web.Http.HttpPost]
        public HttpResponseMessage ListHotel([FromBody]HotelViewModel model)
        {
            using (var ts = db.Database.BeginTransaction())
            {
                try
                {
                   
                    var query = db.agent__data.Join(
                        db.properties_data,
                         s => s.AgentID,
                         sa => sa.AgentID,
                         (s, sa) => new { hotel = s, properties = sa }
                        ).AsQueryable();


                    //Search
                    if (!string.IsNullOrEmpty(model.AgentName))
                    {
                        query = query.Where(e =>e.hotel.AgentName.Contains(model.AgentName));
                    }
                    if (!string.IsNullOrEmpty(model.AgentAddress1))
                    {
                        query = query.Where(e => e.hotel.AgentAddress1.Contains(model.AgentAddress1));
                    }

                    if (!string.IsNullOrEmpty(model.AgentAddress2))
                    {
                        query = query.Where(e => e.hotel.AgentAddress2.Contains(model.AgentAddress2));
                    }

                    if (model.AgentProvince != null && model.AgentProvince != 0)
                    {
                        query = query.Where(e => e.hotel.AgentProvince == model.AgentProvince);
                    }
                    
                    if (!string.IsNullOrEmpty(model.AgentCity))
                    {
                        query = query.Where(e => e.hotel.AgentCity == model.AgentCity);
                    }

                    if (!string.IsNullOrEmpty(model.AgentMobile))
                    {
                        query = query.Where(e => e.hotel.AgentMobile.Contains(model.AgentMobile));
                    }
                    

                    if (!string.IsNullOrEmpty(model.AgentTelephone))
                    {
                        query = query.Where(e => e.hotel.AgentTelephone.Contains(model.AgentTelephone));
                    }

                    if (!string.IsNullOrEmpty(model.AgentTATNumber))
                    {
                        query = query.Where(e => e.hotel.AgentTATNumber == model.AgentTATNumber);
                    }

                    if (!string.IsNullOrEmpty(model.AgentZipCode))
                    {
                        query = query.Where(e => e.hotel.AgentZipCode == model.AgentZipCode);
                    }

                    if (!string.IsNullOrEmpty(model.AgentTelephone))
                    {
                        query = query.Where(e => e.hotel.AgentTelephone == model.AgentTelephone);
                    }




                    List<HotelViewModel> list = query.Select(e => new HotelViewModel
                    {
                        AgentAddress1 = e.hotel.AgentAddress1,
                        AgentAddress2 = e.hotel.AgentAddress2,
                        AgentCity = e.hotel.AgentCity,
                        AgentName = e.hotel.AgentName,
                        AgentProvince = e.hotel.AgentProvince,
                        AgentCode = e.hotel.AgentCode,
                        AgentContactName = e.hotel.AgentContactName,
                        AgentEmail = e.hotel.AgentEmail,
                        AgentFax = e.hotel.AgentFax,
                        AgentID = e.hotel.AgentID,
                        AgentMobile = e.hotel.AgentMobile,
                        AgentTATNumber = e.hotel.AgentTATNumber,
                        AgentRegisterID = e.hotel.AgentRegisterID,
                        AgentTelephone = e.hotel.AgentTelephone,
                        AgentType = e.hotel.AgentType,
                        AgentZipCode = e.hotel.AgentZipCode,
                        Latitude = e.hotel.Latitude,
                        Longitude = e.hotel.Longitude,
                        IDPropertiesAmenities =e.properties.PropertiesAmenities,
                        IDPropertiesCatergory =e.properties.PropertiesCatergory,
                        AgentPictureClient = e.hotel.AgentPictureClient,
                        AgentPictureServer = e.hotel.AgentPictureServer
                    }).ToList();

                    List<HotelViewModel> result = list;
                    for (int index  =0;index < list.Count; index++)
                    {
                        HotelViewModel hotel = list[index];
                        List<string> idAmenities = hotel.IDPropertiesAmenities.Split(new char[] { ',' }).ToList();
                        List<string> idCatergory = hotel.IDPropertiesCatergory.Split(new char[] { ',' }).ToList();



                        if (model.PropertiesCatergory != null && model.PropertiesCatergory.Count > 0)
                        {

                            var queryCatergory = db.poperties_catergory.AsQueryable();
                            queryCatergory = queryCatergory.Where(x => model.PropertiesCatergory.Contains(x.PropertiesCatergoryName.ToString()));
                            List<string> listCatergorySerach = queryCatergory.Select(x => x.PropertiesCatergoryName).ToList();
                            if (listCatergorySerach.Count > 0)
                            {
                                result.RemoveAt(index);
                            }else
                            {
                                QueryPrice(result,hotel,index);
                               
                            }
                        }
                        if (model.PropertiesAmenities != null && model.PropertiesAmenities.Count > 0)
                        {
                            var queryAmenities = db.properties_amenities.AsQueryable();
                            queryAmenities = queryAmenities.Where(x => model.PropertiesAmenities.Contains(x.PropertiesAmenitiesID.ToString()));
                            List<string> listAmenitiesSerach = queryAmenities.Select(x => x.PropertiesAmenitiesName).ToList();

                            if (listAmenitiesSerach.Count > 0)
                            {
                                result.RemoveAt(index);
                            }else
                            {
                                QueryPrice(result, hotel, index);
                            }
                        }
                        else
                        {
                            //Amentities
                            var queryCatergory = db.poperties_catergory.AsQueryable();
                            queryCatergory = queryCatergory.Where(x => idCatergory.Contains(x.PropertiesCatergoryName.ToString()));
                            hotel.PropertiesCatergory = queryCatergory.Select(x => x.PropertiesCatergoryName).ToList();

                            //Catergory
                            var queryAmenities = db.properties_amenities.AsQueryable();
                            queryAmenities = queryAmenities.Where(x => idAmenities.Contains(x.PropertiesAmenitiesID.ToString()));
                            hotel.PropertiesAmenities = queryAmenities.Select(x => x.PropertiesAmenitiesName).ToList();

                            QueryPrice(result, hotel, index);
                        }

                        

                    }
                    
                    return Request.CreateResponse(HttpStatusCode.OK, new { Result = result, Message = "Success", Status = true });

                }
                catch (Exception ex)
                {
                    ts.Rollback();
                    return Request.CreateResponse(HttpStatusCode.OK, new { Result = ex.Message, Message = "Exception", Status = false });
                }

            }


           
        }

        private void QueryPrice(List<HotelViewModel> result, HotelViewModel hotel, int index)
        {
            //Get Price Current
            var queryCalendarPrice = db.calendar_price.AsQueryable();
            queryCalendarPrice = queryCalendarPrice.Where(x => x.AgentID == hotel.AgentID);
            queryCalendarPrice = queryCalendarPrice.Where(x => DateTime.Now >= x.StartDate);
            queryCalendarPrice = queryCalendarPrice.Where(x => DateTime.Now <= x.EndDate);
            double? priceEvent = queryCalendarPrice.Min(x => x.PromotionPrice);

            if (priceEvent != 0 && priceEvent != null)
            {
                //
                hotel.MinPrice = (double)priceEvent;
            }
            else
            {
                var queryCatergoryPrice = db.catergory_room.AsQueryable();
                queryCatergoryPrice = queryCatergoryPrice.Where(x => x.AgentID == hotel.AgentID);
                double? priceMinCaterogory = queryCatergoryPrice.Min(x => x.PriceDefault);
                if (priceMinCaterogory == 0 || priceMinCaterogory == null)
                {
                    priceMinCaterogory = 0;
                }
                hotel.MinPrice = (double)priceMinCaterogory;


            }
            result[index].MinPrice = hotel.MinPrice;
        }


        [System.Web.Http.HttpGet]
        public HttpResponseMessage DetailHotel(int AgentID)
        {
            using (var ts = db.Database.BeginTransaction())
            {
                try
                {
                    var query = db.agent__data.Join(
                      db.properties_data,
                       s => s.AgentID,
                       sa => sa.AgentID,
                       (s, sa) => new { hotel = s, properties = sa }
                      ).AsQueryable();

                    query = query.Where(e =>e.hotel.AgentID == AgentID);

                    HotelViewModel hotel = query.Select(e => new HotelViewModel
                    {
                        AgentAddress1 = e.hotel.AgentAddress1,
                        AgentAddress2 = e.hotel.AgentAddress2,
                        AgentCity = e.hotel.AgentCity,
                        AgentName = e.hotel.AgentName,
                        AgentProvince = e.hotel.AgentProvince,
                        AgentCode = e.hotel.AgentCode,
                        AgentContactName = e.hotel.AgentContactName,
                        AgentEmail = e.hotel.AgentEmail,
                        AgentFax = e.hotel.AgentFax,
                        AgentID = e.hotel.AgentID,
                        AgentMobile = e.hotel.AgentMobile,
                        AgentTATNumber = e.hotel.AgentTATNumber,
                        AgentRegisterID = e.hotel.AgentRegisterID,
                        AgentTelephone = e.hotel.AgentTelephone,
                        AgentType = e.hotel.AgentType,
                        AgentZipCode = e.hotel.AgentZipCode,
                        Latitude = e.hotel.Latitude,
                        Longitude = e.hotel.Longitude,
                        IDPropertiesAmenities = e.properties.PropertiesAmenities,
                        IDPropertiesCatergory = e.properties.PropertiesCatergory, 
                        
                    }).FirstOrDefault();


                    var queryCatergoryRoom = db.catergory_room.AsQueryable();
                    queryCatergoryRoom = queryCatergoryRoom.Where(x =>x.AgentID == AgentID);

                    hotel.ListCatergoryRoom = queryCatergoryRoom.Select(x => new CatergoryRoomViewModel {
                        CatergoryRoomID = x.CatergoryRoomID,
                        Description =x.Description,
                        MaximunAllowingGuest = (int)x.MaximunAllowingGuest,
                        OrderImage = x.OrderImage,
                        PriceDefault = x.PriceDefault,
                        RoomName = x.RoomName 
                    }).ToList();

                    List<string> idAmenities = hotel.IDPropertiesAmenities.Split(new char[] { ',' }).ToList();
                    List<string> idCatergory = hotel.IDPropertiesCatergory.Split(new char[] { ',' }).ToList();


                    //Amentities
                    var queryCatergory = db.poperties_catergory.AsQueryable();
                    queryCatergory = queryCatergory.Where(x => idCatergory.Contains(x.PropertiesCatergoryName.ToString()));
                    hotel.PropertiesCatergory = queryCatergory.Select(x => x.PropertiesCatergoryName).ToList();

                    //Catergory
                    var queryAmenities = db.properties_amenities.AsQueryable();
                    queryAmenities = queryAmenities.Where(x => idAmenities.Contains(x.PropertiesAmenitiesID.ToString()));
                    hotel.PropertiesAmenities = queryAmenities.Select(x => x.PropertiesAmenitiesName).ToList();


                    List<CatergoryRoomViewModel> catergoryList  = hotel.ListCatergoryRoom;


                    for (int index =0;index < hotel.ListCatergoryRoom.Count;index++)
                    {
                        CatergoryRoomViewModel item = hotel.ListCatergoryRoom[index];
                        
                        //Get Price Current
                        var queryCalendarPrice = db.calendar_price.AsQueryable();
                        queryCalendarPrice = queryCalendarPrice.Where(x => x.CatergoryRoomID == item.CatergoryRoomID);
                        queryCalendarPrice = queryCalendarPrice.Where(x => DateTime.Now >= x.StartDate);
                        queryCalendarPrice = queryCalendarPrice.Where(x => DateTime.Now <= x.EndDate);
                        double? priceEvent = queryCalendarPrice.Min(x => x.PromotionPrice);

                        if (priceEvent != 0 && priceEvent != null)
                        {
                            //
                            CalendarPrice calendar = new CalendarPrice();
                            calendar.PromotionPrice = (double)priceEvent;
                            item.CalendarPrices = calendar;
                        }

                        var queryCatergoryPrice = db.catergory_room.AsQueryable();
                        queryCatergoryPrice = queryCatergoryPrice.Where(x => x.CatergoryRoomID == item.CatergoryRoomID);
                        double? priceMinCaterogory = queryCatergoryPrice.Select(x => x.PriceDefault).FirstOrDefault();
                        if (priceMinCaterogory == 0 || priceMinCaterogory == null)
                        {
                            priceMinCaterogory = 0;
                        }
                        catergoryList[index].PriceDefault = (double)priceMinCaterogory;

                    }

                    hotel.ListCatergoryRoom = catergoryList;

                    return Request.CreateResponse(HttpStatusCode.OK, new { Result = hotel, Message = "Success", Status = true });

                }
                catch (Exception ex)
                {
                    ts.Rollback();
                    return Request.CreateResponse(HttpStatusCode.OK, new { Result = ex.Message, Message = "Exception", Status = false });
                }

            }



        }
    }
}
