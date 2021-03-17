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
    partial class TestMinMaxAABB
    {
        [BurstCompile(CompileSynchronously = true)]
        public unsafe class Transform_float4x4
        {
            public struct Arguments : IDisposable
            {
                public Geometry.MinMaxAABB* a;

                public void Init()
                {
                    a = (Geometry.MinMaxAABB*)UnsafeUtility.Malloc(UnsafeUtility.SizeOf<Geometry.MinMaxAABB>() * 100000, UnsafeUtility.AlignOf<Geometry.MinMaxAABB>(), Allocator.Persistent);
                    for (int i = 0; i < 100000; ++i)
                    {
                        a[i] = new Geometry.MinMaxAABB();
                    }

                }

                public void Dispose()
                {
                    UnsafeUtility.Free(a, Allocator.Persistent);
                }
            }

            public static void CommonTestFunction(ref Arguments args)
            {
                for (int i = 0; i < 100000; ++i)
                {
                    args.a[i] = Geometry.Math.Transform(float4x4.identity, args.a[i]);
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
        public void Transform_float4x4_mono()
        {
            Transform_float4x4.TestFunction testFunction = Transform_float4x4.MonoTestFunction;
            var args = new Transform_float4x4.Arguments();
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
        public void Transform_float4x4_burst()
        {
            FunctionPointer<Transform_float4x4.TestFunction> testFunction = BurstCompiler.CompileFunctionPointer<Transform_float4x4.TestFunction>(Transform_float4x4.BurstTestFunction);
            var args = new Transform_float4x4.Arguments();
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
        public unsafe class Transform_float3x3
        {
            public struct Arguments : IDisposable
            {
                public Geometry.MinMaxAABB* a;

                public void Init()
                {
                    a = (Geometry.MinMaxAABB*)UnsafeUtility.Malloc(UnsafeUtility.SizeOf<Geometry.MinMaxAABB>() * 100000, UnsafeUtility.AlignOf<Geometry.MinMaxAABB>(), Allocator.Persistent);
                    for (int i = 0; i < 100000; ++i)
                    {
                        a[i] = new Geometry.MinMaxAABB();
                    }

                }

                public void Dispose()
                {
                    UnsafeUtility.Free(a, Allocator.Persistent);
                }
            }

            public static void CommonTestFunction(ref Arguments args)
            {
                for (int i = 0; i < 100000; ++i)
                {
                    args.a[i] = Geometry.Math.Transform(float3x3.identity, args.a[i]);
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
        public void Transform_float3x3_mono()
        {
            Transform_float3x3.TestFunction testFunction = Transform_float3x3.MonoTestFunction;
            var args = new Transform_float3x3.Arguments();
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
        public void Transform_float3x3_burst()
        {
            FunctionPointer<Transform_float3x3.TestFunction> testFunction = BurstCompiler.CompileFunctionPointer<Transform_float3x3.TestFunction>(Transform_float3x3.BurstTestFunction);
            var args = new Transform_float3x3.Arguments();
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
