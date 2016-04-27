using System;
namespace Mars
{
    public interface IRobots
    {
        void Add(Robot input);
        System.Collections.Generic.List<Robot> Get();
        void Remove(Robot input);
    }
}
