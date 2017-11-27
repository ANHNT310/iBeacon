using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iBeacon_WcfServiceLibrary.Database;

namespace iBeacon_WcfServiceLibrary.DAL
{
    public class Store_DAL
    {
        readonly BeaconEntities _beaconEntities = new BeaconEntities();

        public List<STORE> GtList()
        {
            return _beaconEntities.STOREs.ToList();
        }

        public STORE GetStores(int id)
        {
            return _beaconEntities.STOREs.FirstOrDefault(e => e.ID == id);
        }

        public bool Create(STORE obj)
        {
            try
            {
                _beaconEntities.STOREs.Add(new STORE
                {
                    GUID = Guid.NewGuid().ToString(),
                    STORE_NAME = obj.STORE_NAME,
                    MALL_ID = obj.MALL_ID,
                    BROADCAST_ENABLE = obj.BROADCAST_ENABLE,
                    HOME_PAGE = obj.HOME_PAGE,
                });
                _beaconEntities.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
                throw;
            }
        }

        public bool Update(STORE obj)
        {
            try
            {
                var item = GetStores(obj.ID);
                if (item != null)
                {
                    item.STORE_NAME = obj.STORE_NAME;
                    item.MALL_ID = obj.MALL_ID;
                    item.BROADCAST_ENABLE = obj.BROADCAST_ENABLE;
                    item.HOME_PAGE = obj.HOME_PAGE;
                }
                _beaconEntities.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
                throw;
            }
        }

        public void Delete(int id)
        {
            try
            {
                var item = GetStores(id);
                if (item != null)
                {
                    _beaconEntities.STOREs.Remove(item);
                }
                _beaconEntities.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
