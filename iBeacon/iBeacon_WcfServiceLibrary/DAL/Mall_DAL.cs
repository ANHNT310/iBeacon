using iBeacon_WcfServiceLibrary.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iBeacon_WcfServiceLibrary.DAL
{
    public class Mall_DAL
    {
        readonly BeaconEntities _beaconEntities = new BeaconEntities();

        public List<MALL> GetList()
        {
            return _beaconEntities.MALLs.ToList();
        }

        public MALL GetMallById(int id)
        {
            return _beaconEntities.MALLs.FirstOrDefault(e => e.ID == id);
        }

        public bool Create(MALL mall)
        {
            try
            {
                _beaconEntities.MALLs.Add(new MALL
                {
                    MALL_GUID = Guid.NewGuid().ToString(),
                    MALL_NAME = mall.MALL_NAME,
                    LOCATION_CODE = mall.LOCATION_CODE,
                    BEACON_ID = mall.BEACON_ID,
                    LAT = mall.LAT,
                    LONG = mall.LONG,
                    RADIUS = mall.RADIUS,
                    BROADCAST_ENABLE = mall.BROADCAST_ENABLE
                });
                _beaconEntities.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool UpdateMall(MALL mall)
        {
            try
            {
                var item = GetMallById(mall.ID);
                if (item != null)
                {
                    item.MALL_NAME = mall.MALL_NAME;
                    item.LOCATION_CODE = mall.LOCATION_CODE;
                    item.BEACON_ID = mall.BEACON_ID;
                    item.LAT = mall.LAT;
                    item.LONG = mall.LONG;
                    item.RADIUS = mall.RADIUS;
                    item.BROADCAST_ENABLE = mall.BROADCAST_ENABLE;
                }
                _beaconEntities.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool DeleteMall(int id)
        {
            try
            {
                var item = GetMallById(id);
                if (item != null)
                {
                    _beaconEntities.MALLs.Remove(item);
                }
                _beaconEntities.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
    }
}
