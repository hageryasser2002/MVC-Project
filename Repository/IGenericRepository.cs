namespace MVC_Projec2.Repository
{
    public interface IGenericRepository<T>
    {
        //CRUD Operation
        List<T> GetAll();
        T GetById(int id);

        void insert(T obj);
        void Update(T obj);
        void Delete(T obj);

        void Save();

    }
}
