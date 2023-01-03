namespace CricketManager.Services
{
    public interface IDataRepository<TEntity>
    {
        public List<TEntity> Get();
        public List<TEntity> GetDataByName(string Name);
        public TEntity GetDetail(int Id);
        public void Add(TEntity entity);
        public void Update(TEntity entity);
        public void Delete(TEntity entity);
    }
}
