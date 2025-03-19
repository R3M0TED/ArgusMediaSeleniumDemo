using NUnit.Framework;

[assembly: Parallelizable(ParallelScope.Fixtures)]

#if DEBUG
[assembly: LevelOfParallelism(2)] 
#else
[assembly: LevelOfParallelism(4)]
#endif