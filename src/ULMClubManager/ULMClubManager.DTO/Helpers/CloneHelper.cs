using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ULMClubManager.DTO.Helpers
{
    /// <summary>
    /// Binary serialization helps you to clone objects without implementing 
    /// interfaces. The idea is simple — serialize an object graph into memory 
    /// and then deserialize it back to an object.
    /// Source : https://levelup.gitconnected.com/5-ways-to-clone-an-object-in-c-d1374ec28efa
    /// </summary>
    public static class CloneHelper
    {
        public static T CreateDeepCopy<T>(this T obj)
        {
            using (var ms = new MemoryStream())
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(ms, obj);
                ms.Seek(0, SeekOrigin.Begin);
                return (T)formatter.Deserialize(ms);
            }
        }
    }
}
