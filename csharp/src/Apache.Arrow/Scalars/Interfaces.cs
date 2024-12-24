using Apache.Arrow.Types;

namespace Apache.Arrow.Scalars
{
    public interface Scalar
    {
        IArrowType DataType { get; }
    }
}
