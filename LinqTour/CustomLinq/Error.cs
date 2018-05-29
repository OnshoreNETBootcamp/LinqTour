using System;

namespace LinqTour.CustomLinq
{
    public static class Error
    {
        public static ArgumentException ArgumentNull(string source)
        {
            return new ArgumentException($"The supplied parameter: {source} was null");
        }

        public static InvalidOperationException NoElements()
        {
            return new InvalidOperationException("The sequence returned no elements");
        }

        public static InvalidOperationException MoreThanOneElement()
        {
            return new InvalidOperationException("The sequence returned more than 1 element.");
        }

        public static InvalidOperationException NoMatch()
        {
            return new InvalidOperationException("No match was found");
        }

        public static InvalidOperationException MoreThanOneMatch()
        {
            return new InvalidOperationException("Predicated returned more than 1 match.");
        }

        public static InvalidOperationException ArgumentOutOfRange(string source)
        {
            return new InvalidOperationException($"The argument was out of range: {source}");
        }

        public static InvalidOperationException NotSupported()
        {
            return new InvalidOperationException("The following method is not supported on the given collection.");
        }
    }
}
