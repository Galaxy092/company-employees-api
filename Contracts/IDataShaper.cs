using Entities.Models;
using System.Dynamic;

namespace Contracts
{
    public interface IDataShaper<T>
    {
        IEnumerable<Entity> ShapeData(IEnumerable<T> entities, string fieldsString); 
        Entity ShapeData(T entity, string fieldsString);
    }
}
