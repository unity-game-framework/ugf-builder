using JetBrains.Annotations;

namespace UGF.Builder.Runtime
{
    public interface IBuilder
    {
        object Build([CanBeNull] object[] arguments);
    }
}