using System.Linq;
using Biz.Interfaces;
using Core.Domains;
using Data;

namespace Biz.Services

{
    public class AssetService : IAssetService
    {
        private readonly IRepository<Asset> _assetRepo;
        private readonly IRepository<Facility> _facilityRepo;

        public AssetService()
        {
            _assetRepo = new Repository<Asset>();
            _facilityRepo = new Repository<Facility>();
        }
        public AssetService(IRepository<Asset> assetRepo)
        {
            _assetRepo = assetRepo;
            _facilityRepo = new Repository<Facility>();
        }

        public AssetService(IRepository<Asset> assetRepo, IRepository<Facility> facilityRepo)
        {
            _assetRepo = assetRepo;
            _facilityRepo = facilityRepo;
        }

        public void Delete(Asset asset)
        {
            _assetRepo.Delete(asset);
        }

        public IQueryable<Asset> GetAll()
        {
            return _assetRepo.Table;
        }

        public Asset GetById(int id)
        {
            return _assetRepo.GetById(id);
           // throw new System.NotImplementedException();
        }

        public void InsertOrUpdate(Asset asset)
        {
            if (asset.Id == 0)
            {
                _assetRepo.Insert(asset);
                Facility facility = _facilityRepo.GetById(asset.FacilityId);
                Asset newAsset = GetAssetIdForFacility(asset);
                facility.AssetId = newAsset.Id;
                _facilityRepo.Update(facility);
            }
            else
            {
                _assetRepo.Update(asset);
            }
        }
        public Asset GetAssetIdForFacility(Asset asset)
        {
            var queryTable = _assetRepo.Table;
            Asset res = queryTable.Where(x => x.FacilityId == (asset.FacilityId)).First<Asset>();
            return res;
        }
    }
    


}