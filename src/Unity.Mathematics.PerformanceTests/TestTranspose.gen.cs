//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated. To update the generation of this file, modify and re-run Unity.Mathematics.CodeGen.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using NUnit.Framework;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.PerformanceTesting;
using Unity.Mathematics.Geometry;
using Unity.Burst;

namespace Unity.Mathematics.PerformanceTests
{
    partial class TestTranspose
    {
        [BurstCompile(CompileSynchronously = true)]
        public unsafe class transpose_float4x4
        {
            public struct Arguments : IDisposable
            {
                public float4x4* m;

                public void Init()
                {
                    m = (float4x4*)UnsafeUtility.Malloc(UnsafeUtility.SizeOf<float4x4>() * 10000, UnsafeUtility.AlignOf<float4x4>(), Allocator.Persistent);
                    for (int i = 0; i < 10000; ++i)
                    {
                        m[i] = float4x4.identity;
                    }

                }

                public void Dispose()
                {
                    UnsafeUtility.Free(m, Allocator.Persistent);
                }
            }

            public static void CommonTestFunction(ref Arguments args)
            {
                for (int i = 0; i < 10000; ++i)
                {
                    args.m[i] = math.transpose(args.m[i]);
                }
            }

            public static void MonoTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            [BurstCompile(CompileSynchronously = true)]
            public static void BurstTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            public delegate void TestFunction(ref Arguments args);
        }

        [Test, Performance]
        public void transpose_float4x4_mono()
        {
            transpose_float4x4.TestFunction testFunction = transpose_float4x4.MonoTestFunction;
            var args = new transpose_float4x4.Arguments();
            args.Init();

            var monoSampleGroup = new SampleGroup("Mono", SampleUnit.Microsecond);            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .SampleGroup(monoSampleGroup)
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
            args.Dispose();
        }

        [Test, Performance]
        public void transpose_float4x4_burst()
        {
            FunctionPointer<transpose_float4x4.TestFunction> testFunction = BurstCompiler.CompileFunctionPointer<transpose_float4x4.TestFunction>(transpose_float4x4.BurstTestFunction);
            var args = new transpose_float4x4.Arguments();
            args.Init();

            var burstSampleGroup = new SampleGroup("Burst", SampleUnit.Microsecond);            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .SampleGroup(burstSampleGroup)
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
            args.Dispose();
        }
        [BurstCompile(CompileSynchronously = true)]
        public unsafe class transpose_float3x3
        {
            public struct Arguments : IDisposable
            {
                public float3x3* m;

                public void Init()
                {
                    m = (float3x3*)UnsafeUtility.Malloc(UnsafeUtility.SizeOf<float3x3>() * 10000, UnsafeUtility.AlignOf<float3x3>(), Allocator.Persistent);
                    for (int i = 0; i < 10000; ++i)
                    {
                        m[i] = float3x3.identity;
                    }

                }

                public void Dispose()
                {
                    UnsafeUtility.Free(m, Allocator.Persistent);
                }
            }

            public static void CommonTestFunction(ref Arguments args)
            {
                for (int i = 0; i < 10000; ++i)
                {
                    args.m[i] = math.transpose(args.m[i]);
                }
            }

            public static void MonoTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            [BurstCompile(CompileSynchronously = true)]
            public static void BurstTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            public delegate void TestFunction(ref Arguments args);
        }

        [Test, Performance]
        public void transpose_float3x3_mono()
        {
            transpose_float3x3.TestFunction testFunction = transpose_float3x3.MonoTestFunction;
            var args = new transpose_float3x3.Arguments();
            args.Init();

            var monoSampleGroup = new SampleGroup("Mono", SampleUnit.Microsecond);            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .SampleGroup(monoSampleGroup)
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
            args.Dispose();
        }

        [Test, Performance]
        public void transpose_float3x3_burst()
        {
            FunctionPointer<transpose_float3x3.TestFunction> testFunction = BurstCompiler.CompileFunctionPointer<transpose_float3x3.TestFunction>(transpose_float3x3.BurstTestFunction);
            var args = new transpose_float3x3.Arguments();
            args.Init();

            var burstSampleGroup = new SampleGroup("Burst", SampleUnit.Microsecond);            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .SampleGroup(burstSampleGroup)
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
            args.Dispose();
        }
        [BurstCompile(CompileSynchronously = true)]
        public unsafe class transpose_float2x2
        {
            public struct Arguments : IDisposable
            {
                public float2x2* m;

                public void Init()
                {
                    m = (float2x2*)UnsafeUtility.Malloc(UnsafeUtility.SizeOf<float2x2>() * 10000, UnsafeUtility.AlignOf<float2x2>(), Allocator.Persistent);
                    for (int i = 0; i < 10000; ++i)
                    {
                        m[i] = float2x2.identity;
                    }

                }

                public void Dispose()
                {
                    UnsafeUtility.Free(m, Allocator.Persistent);
                }
            }

            public static void CommonTestFunction(ref Arguments args)
            {
                for (int i = 0; i < 10000; ++i)
                {
                    args.m[i] = math.transpose(args.m[i]);
                }
            }

            public static void MonoTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            [BurstCompile(CompileSynchronously = true)]
            public static void BurstTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            public delegate void TestFunction(ref Arguments args);
        }

        [Test, Performance]
        public void transpose_float2x2_mono()
        {
            transpose_float2x2.TestFunction testFunction = transpose_float2x2.MonoTestFunction;
            var args = new transpose_float2x2.Arguments();
            args.Init();

            var monoSampleGroup = new SampleGroup("Mono", SampleUnit.Microsecond);            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .SampleGroup(monoSampleGroup)
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
            args.Dispose();
        }

        [Test, Performance]
        public void transpose_float2x2_burst()
        {
            FunctionPointer<transpose_float2x2.TestFunction> testFunction = BurstCompiler.CompileFunctionPointer<transpose_float2x2.TestFunction>(transpose_float2x2.BurstTestFunction);
            var args = new transpose_float2x2.Arguments();
            args.Init();

            var burstSampleGroup = new SampleGroup("Burst", SampleUnit.Microsecond);            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .SampleGroup(burstSampleGroup)
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
            args.Dispose();
        }
        [BurstCompile(CompileSynchronously = true)]
        public unsafe class transpose_double4x4
        {
            public struct Arguments : IDisposable
            {
                public double4x4* m;

                public void Init()
                {
                    m = (double4x4*)UnsafeUtility.Malloc(UnsafeUtility.SizeOf<double4x4>() * 10000, UnsafeUtility.AlignOf<double4x4>(), Allocator.Persistent);
                    for (int i = 0; i < 10000; ++i)
                    {
                        m[i] = double4x4.identity;
                    }

                }

                public void Dispose()
                {
                    UnsafeUtility.Free(m, Allocator.Persistent);
                }
            }

            public static void CommonTestFunction(ref Arguments args)
            {
                for (int i = 0; i < 10000; ++i)
                {
                    args.m[i] = math.transpose(args.m[i]);
                }
            }

            public static void MonoTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            [BurstCompile(CompileSynchronously = true)]
            public static void BurstTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            public delegate void TestFunction(ref Arguments args);
        }

        [Test, Performance]
        public void transpose_double4x4_mono()
        {
            transpose_double4x4.TestFunction testFunction = transpose_double4x4.MonoTestFunction;
            var args = new transpose_double4x4.Arguments();
            args.Init();

            var monoSampleGroup = new SampleGroup("Mono", SampleUnit.Microsecond);            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .SampleGroup(monoSampleGroup)
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
            args.Dispose();
        }

        [Test, Performance]
        public void transpose_double4x4_burst()
        {
            FunctionPointer<transpose_double4x4.TestFunction> testFunction = BurstCompiler.CompileFunctionPointer<transpose_double4x4.TestFunction>(transpose_double4x4.BurstTestFunction);
            var args = new transpose_double4x4.Arguments();
            args.Init();

            var burstSampleGroup = new SampleGroup("Burst", SampleUnit.Microsecond);            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .SampleGroup(burstSampleGroup)
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
            args.Dispose();
        }
        [BurstCompile(CompileSynchronously = true)]
        public unsafe class transpose_double3x3
        {
            public struct Arguments : IDisposable
            {
                public double3x3* m;

                public void Init()
                {
                    m = (double3x3*)UnsafeUtility.Malloc(UnsafeUtility.SizeOf<double3x3>() * 10000, UnsafeUtility.AlignOf<double3x3>(), Allocator.Persistent);
                    for (int i = 0; i < 10000; ++i)
                    {
                        m[i] = double3x3.identity;
                    }

                }

                public void Dispose()
                {
                    UnsafeUtility.Free(m, Allocator.Persistent);
                }
            }

            public static void CommonTestFunction(ref Arguments args)
            {
                for (int i = 0; i < 10000; ++i)
                {
                    args.m[i] = math.transpose(args.m[i]);
                }
            }

            public static void MonoTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            [BurstCompile(CompileSynchronously = true)]
            public static void BurstTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            public delegate void TestFunction(ref Arguments args);
        }

        [Test, Performance]
        public void transpose_double3x3_mono()
        {
            transpose_double3x3.TestFunction testFunction = transpose_double3x3.MonoTestFunction;
            var args = new transpose_double3x3.Arguments();
            args.Init();

            var monoSampleGroup = new SampleGroup("Mono", SampleUnit.Microsecond);            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .SampleGroup(monoSampleGroup)
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
            args.Dispose();
        }

        [Test, Performance]
        public void transpose_double3x3_burst()
        {
            FunctionPointer<transpose_double3x3.TestFunction> testFunction = BurstCompiler.CompileFunctionPointer<transpose_double3x3.TestFunction>(transpose_double3x3.BurstTestFunction);
            var args = new transpose_double3x3.Arguments();
            args.Init();

            var burstSampleGroup = new SampleGroup("Burst", SampleUnit.Microsecond);            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .SampleGroup(burstSampleGroup)
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
            args.Dispose();
        }
        [BurstCompile(CompileSynchronously = true)]
        public unsafe class transpose_double2x2
        {
            public struct Arguments : IDisposable
            {
                public double2x2* m;

                public void Init()
                {
                    m = (double2x2*)UnsafeUtility.Malloc(UnsafeUtility.SizeOf<double2x2>() * 10000, UnsafeUtility.AlignOf<double2x2>(), Allocator.Persistent);
                    for (int i = 0; i < 10000; ++i)
                    {
                        m[i] = double2x2.identity;
                    }

                }

                public void Dispose()
                {
                    UnsafeUtility.Free(m, Allocator.Persistent);
                }
            }

            public static void CommonTestFunction(ref Arguments args)
            {
                for (int i = 0; i < 10000; ++i)
                {
                    args.m[i] = math.transpose(args.m[i]);
                }
            }

            public static void MonoTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            [BurstCompile(CompileSynchronously = true)]
            public static void BurstTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            public delegate void TestFunction(ref Arguments args);
        }

        [Test, Performance]
        public void transpose_double2x2_mono()
        {
            transpose_double2x2.TestFunction testFunction = transpose_double2x2.MonoTestFunction;
            var args = new transpose_double2x2.Arguments();
            args.Init();

            var monoSampleGroup = new SampleGroup("Mono", SampleUnit.Microsecond);            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .SampleGroup(monoSampleGroup)
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
            args.Dispose();
        }

        [Test, Performance]
        public void transpose_double2x2_burst()
        {
            FunctionPointer<transpose_double2x2.TestFunction> testFunction = BurstCompiler.CompileFunctionPointer<transpose_double2x2.TestFunction>(transpose_double2x2.BurstTestFunction);
            var args = new transpose_double2x2.Arguments();
            args.Init();

            var burstSampleGroup = new SampleGroup("Burst", SampleUnit.Microsecond);            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .SampleGroup(burstSampleGroup)
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
            args.Dispose();
        }
    }
}
