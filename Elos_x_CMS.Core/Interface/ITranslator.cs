namespace Elos_x_CMS.Core.Interface
{
    public interface ITranslator<X, Y>
    {
        Y Translate(X value);
        X Translate(Y value);
    }
}
