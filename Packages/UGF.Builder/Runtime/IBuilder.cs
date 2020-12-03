namespace UGF.Builder.Runtime
{
    public interface IBuilder
    {
        T Build<T>(object[] arguments);
        object Build(object[] arguments);
    }
}
