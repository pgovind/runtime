// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Runtime.Intrinsics
{
    internal static class Vector64
    {
        public static Vector64<ulong> Create(ulong value) => throw new PlatformNotSupportedException();
        public static Vector64<uint> CreateScalar(uint value) => throw new PlatformNotSupportedException();
        public static Vector64<byte> AsByte<T>(this Vector64<T> vector) where T : struct => throw new PlatformNotSupportedException();
    }
    internal readonly struct Vector64<T>
        where T : struct
    {
    }

    internal static class Vector128
    {
        public static Vector128<short> Create(short value) => throw new PlatformNotSupportedException();
        public static Vector128<ushort> Create(ushort value) => throw new PlatformNotSupportedException();
        public static Vector128<ulong> CreateScalarUnsafe(ulong value) => throw new PlatformNotSupportedException();
        public static Vector128<byte> AsByte<T>(this Vector128<T> vector) where T : struct => throw new PlatformNotSupportedException();
        public static Vector128<short> AsInt16<T>(this Vector128<T> vector) where T : struct => throw new PlatformNotSupportedException();
        public static Vector128<ushort> AsUInt16<T>(this Vector128<T> vector) where T : struct => throw new PlatformNotSupportedException();
        public static Vector128<uint> AsUInt32<T>(this Vector128<T> vector) where T : struct => throw new PlatformNotSupportedException();
        public static Vector128<ulong> AsUInt64<T>(this Vector128<T> vector) where T : struct => throw new PlatformNotSupportedException();
        public static T GetElement<T>(this Vector128<T> vector, int index) where T : struct => throw new PlatformNotSupportedException();
        public static T ToScalar<T>(this Vector64<T> vector) where T : struct => throw new PlatformNotSupportedException();
    }
    internal readonly struct Vector128<T>
        where T : struct
    {
        public static Vector128<T> Zero => throw new PlatformNotSupportedException();
        public static int Count => throw new PlatformNotSupportedException();
        public static T ToScalar() => throw new PlatformNotSupportedException();
    }
}

namespace System.Runtime.Intrinsics.X86
{
    internal static class X86Base
    {
        internal static class X64
        {
            public const bool IsSupported = false;
            internal static ulong BitScanForward(ulong value) => throw new PlatformNotSupportedException();
            internal static ulong BitScanReverse(ulong value) => throw new PlatformNotSupportedException();
        }
        public const bool IsSupported = false;
        internal static uint BitScanForward(uint value) => throw new PlatformNotSupportedException();
        internal static uint BitScanReverse(uint value) => throw new PlatformNotSupportedException();
    }
    internal abstract class Bmi1
    {
        public abstract class X64
        {
            public const bool IsSupported = false;
            public static ulong TrailingZeroCount(ulong value) => throw new PlatformNotSupportedException();
        }
        public const bool IsSupported = false;
        public static uint TrailingZeroCount(uint value) => throw new PlatformNotSupportedException();
    }
    internal abstract class Lzcnt
    {
        public abstract class X64
        {
            public const bool IsSupported = false;
            public static ulong LeadingZeroCount(ulong value) => throw new PlatformNotSupportedException();
        }
        public const bool IsSupported = false;
        public static uint LeadingZeroCount(uint value) => throw new PlatformNotSupportedException();
    }
    internal abstract class Popcnt
    {
        public abstract class X64
        {
            public const bool IsSupported = false;
            public static ulong PopCount(ulong value) => throw new PlatformNotSupportedException();
        }
        public const bool IsSupported = false;
        public static uint PopCount(uint value) => throw new PlatformNotSupportedException();
    }

    internal abstract class Sse2
    {
        public abstract class X64
        {
            public const bool IsSupported = false;
            public static Vector128<ulong> ConvertScalarToVector128UInt64(ulong value) => throw new PlatformNotSupportedException();
            public static ulong ConvertToUInt64(Vector128<ulong> value) => throw new PlatformNotSupportedException();
        }
        public const bool IsSupported = false;
        public static Vector128<ushort> Add(Vector128<ushort> left, Vector128<ushort> right) => throw new PlatformNotSupportedException();
        public static Vector128<ushort> AddSaturate(Vector128<ushort> left, Vector128<ushort> right) => throw new PlatformNotSupportedException();
        public static Vector128<ushort> AndNot(Vector128<ushort> left, Vector128<ushort> right) => throw new PlatformNotSupportedException();
        public static Vector128<short> CompareGreaterThan(Vector128<short> left, Vector128<short> right) => throw new PlatformNotSupportedException();
        public static Vector128<short> CompareLessThan(Vector128<short> left, Vector128<short> right) => throw new PlatformNotSupportedException();
        public static Vector128<uint> ConvertScalarToVector128UInt32(uint value) => throw new PlatformNotSupportedException();
        public static uint ConvertToUInt32(Vector128<uint> value) => throw new PlatformNotSupportedException();
        public static unsafe Vector128<byte> LoadAlignedVector128(byte* address) => throw new PlatformNotSupportedException();
        public static unsafe Vector128<ushort> LoadAlignedVector128(ushort* address) => throw new PlatformNotSupportedException();
        public static unsafe Vector128<byte> LoadVector128(byte* address) => throw new PlatformNotSupportedException();
        public static unsafe Vector128<short> LoadVector128(short* address) => throw new PlatformNotSupportedException();
        public static unsafe Vector128<ushort> LoadVector128(ushort* address) => throw new PlatformNotSupportedException();
        public static int MoveMask(Vector128<byte> value) => throw new PlatformNotSupportedException();
        public static Vector128<short> Or(Vector128<short> left, Vector128<short> right) => throw new PlatformNotSupportedException();
        public static Vector128<ushort> Or(Vector128<ushort> left, Vector128<ushort> right) => throw new PlatformNotSupportedException();
        public static Vector128<byte> PackUnsignedSaturate(Vector128<short> left, Vector128<short> right) => throw new PlatformNotSupportedException();
        public static Vector128<ushort> ShiftRightLogical(Vector128<ushort> value, byte count) => throw new PlatformNotSupportedException();
        public static unsafe void Store(byte* address, Vector128<byte> source) => throw new PlatformNotSupportedException();
        public static unsafe void StoreAligned(byte* address, Vector128<byte> source) => throw new PlatformNotSupportedException();
        public static unsafe void StoreScalar(ulong* address, Vector128<ulong> source) => throw new PlatformNotSupportedException();
        public static Vector128<ushort> Subtract(Vector128<ushort> left, Vector128<ushort> right) => throw new PlatformNotSupportedException();
        public static Vector128<byte> UnpackHigh(Vector128<byte> left, Vector128<byte> right) => throw new PlatformNotSupportedException();
        public static Vector128<byte> UnpackLow(Vector128<byte> left, Vector128<byte> right) => throw new PlatformNotSupportedException();
    }

    internal abstract class Sse41
    {
        public abstract class X64
        {
            public const bool IsSupported = false;
        }
        public const bool IsSupported = false;
        public static Vector128<ushort> Min(Vector128<ushort> left, Vector128<ushort> right) => throw new PlatformNotSupportedException();
        public static bool TestZ(Vector128<short> left, Vector128<short> right) => throw new PlatformNotSupportedException();
        public static bool TestZ(Vector128<ushort> left, Vector128<ushort> right) => throw new PlatformNotSupportedException();
    }
}

namespace System.Runtime.Intrinsics.Arm
{
    internal abstract class ArmBase
    {
        public abstract class Arm64
        {
            public const bool IsSupported = false;
            public static int LeadingZeroCount(ulong value) => throw new PlatformNotSupportedException();
            public static uint ReverseElementBits(ulong value) => throw new PlatformNotSupportedException();
        }
        public const bool IsSupported = false;
        public static int LeadingZeroCount(uint value) => throw new PlatformNotSupportedException();
        public static uint ReverseElementBits(uint value) => throw new PlatformNotSupportedException();
    }

    internal abstract class AdvSimd : ArmBase
    {
        public new abstract class Arm64 : ArmBase.Arm64
        {
            public static Vector64<byte> AddAcross(Vector64<byte> value) => throw new PlatformNotSupportedException();

            public static Vector64<byte> ZipHigh(Vector64<byte> left, Vector64<byte> right) { throw new PlatformNotSupportedException(); }

            public static Vector64<short> ZipHigh(Vector64<short> left, Vector64<short> right) { throw new PlatformNotSupportedException(); }

            public static Vector64<int> ZipHigh(Vector64<int> left, Vector64<int> right) { throw new PlatformNotSupportedException(); }

            public static Vector64<sbyte> ZipHigh(Vector64<sbyte> left, Vector64<sbyte> right) { throw new PlatformNotSupportedException(); }

            public static Vector64<float> ZipHigh(Vector64<float> left, Vector64<float> right) { throw new PlatformNotSupportedException(); }

            public static Vector64<ushort> ZipHigh(Vector64<ushort> left, Vector64<ushort> right) { throw new PlatformNotSupportedException(); }

            public static Vector64<uint> ZipHigh(Vector64<uint> left, Vector64<uint> right) { throw new PlatformNotSupportedException(); }

            public static Vector128<byte> ZipHigh(Vector128<byte> left, Vector128<byte> right) { throw new PlatformNotSupportedException(); }

            public static Vector128<double> ZipHigh(Vector128<double> left, Vector128<double> right) { throw new PlatformNotSupportedException(); }

            public static Vector128<short> ZipHigh(Vector128<short> left, Vector128<short> right) { throw new PlatformNotSupportedException(); }

            public static Vector128<int> ZipHigh(Vector128<int> left, Vector128<int> right) { throw new PlatformNotSupportedException(); }

            public static Vector128<long> ZipHigh(Vector128<long> left, Vector128<long> right) { throw new PlatformNotSupportedException(); }

            public static Vector128<sbyte> ZipHigh(Vector128<sbyte> left, Vector128<sbyte> right) { throw new PlatformNotSupportedException(); }

            public static Vector128<float> ZipHigh(Vector128<float> left, Vector128<float> right) { throw new PlatformNotSupportedException(); }

            public static Vector128<ushort> ZipHigh(Vector128<ushort> left, Vector128<ushort> right) { throw new PlatformNotSupportedException(); }

            public static Vector128<uint> ZipHigh(Vector128<uint> left, Vector128<uint> right) { throw new PlatformNotSupportedException(); }

            public static Vector128<ulong> ZipHigh(Vector128<ulong> left, Vector128<ulong> right) { throw new PlatformNotSupportedException(); }

            public static Vector64<byte> ZipLow(Vector64<byte> left, Vector64<byte> right) { throw new PlatformNotSupportedException(); }

            public static Vector64<short> ZipLow(Vector64<short> left, Vector64<short> right) { throw new PlatformNotSupportedException(); }

            public static Vector64<int> ZipLow(Vector64<int> left, Vector64<int> right) { throw new PlatformNotSupportedException(); }

            public static Vector64<sbyte> ZipLow(Vector64<sbyte> left, Vector64<sbyte> right) { throw new PlatformNotSupportedException(); }

            public static Vector64<float> ZipLow(Vector64<float> left, Vector64<float> right) { throw new PlatformNotSupportedException(); }

            public static Vector64<ushort> ZipLow(Vector64<ushort> left, Vector64<ushort> right) { throw new PlatformNotSupportedException(); }

            public static Vector64<uint> ZipLow(Vector64<uint> left, Vector64<uint> right) { throw new PlatformNotSupportedException(); }

            public static Vector128<byte> ZipLow(Vector128<byte> left, Vector128<byte> right) { throw new PlatformNotSupportedException(); }

            public static Vector128<double> ZipLow(Vector128<double> left, Vector128<double> right) { throw new PlatformNotSupportedException(); }

            public static Vector128<short> ZipLow(Vector128<short> left, Vector128<short> right) { throw new PlatformNotSupportedException(); }

            public static Vector128<int> ZipLow(Vector128<int> left, Vector128<int> right) { throw new PlatformNotSupportedException(); }

            public static Vector128<long> ZipLow(Vector128<long> left, Vector128<long> right) { throw new PlatformNotSupportedException(); }

            public static Vector128<sbyte> ZipLow(Vector128<sbyte> left, Vector128<sbyte> right) { throw new PlatformNotSupportedException(); }

            public static Vector128<float> ZipLow(Vector128<float> left, Vector128<float> right) { throw new PlatformNotSupportedException(); }

            public static Vector128<ushort> ZipLow(Vector128<ushort> left, Vector128<ushort> right) { throw new PlatformNotSupportedException(); }

            public static Vector128<uint> ZipLow(Vector128<uint> left, Vector128<uint> right) { throw new PlatformNotSupportedException(); }

            public static Vector128<ulong> ZipLow(Vector128<ulong> left, Vector128<ulong> right) { throw new PlatformNotSupportedException(); }
        }

        public static Vector64<byte> PopCount(Vector64<byte> value) => throw new PlatformNotSupportedException();

        public static Vector128<double> DuplicateToVector128(double value) { throw new PlatformNotSupportedException(); }

        public static Vector128<long> DuplicateToVector128(long value) { throw new PlatformNotSupportedException(); }

        public static Vector128<ulong> DuplicateToVector128(ulong value) { throw new PlatformNotSupportedException(); }

    }
}
