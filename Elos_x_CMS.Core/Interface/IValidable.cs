namespace Elos_x_CMS.Core.Interface
{
    public interface IValidable<T>
    {
        void Validate(T value);
    }
}
