using System.Text;

namespace CSharpApp.WorkSpace
{
    public class Hashmap<K, V>
    {
        private List<LinkedList<Entity>> list;
        private int size = 0;
        private float lf = 0.5f; // load factor : ( n/m )

        public Hashmap()
        {
            list = new List<LinkedList<Entity>>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(new LinkedList<Entity>());
            }
        }

        public void Put(K key, V value)
        {
            int hash = Math.Abs(key!.GetHashCode() % list.Count);
            var entities = list[hash];

            foreach (var entity in entities)
            {
                if (entity.key!.Equals(key))
                {
                    entity.value = value;
                    return;
                }
            }

            if ((float)size / list.Count > lf)
            {
                ReHash();
            }

            entities.AddFirst(new Entity(key, value));

            size += 1;
        }

        private void ReHash()
        {
            System.Console.WriteLine();
            var old = list;
            list = new List<LinkedList<Entity>>();

            size = 0;

            for (int i = 0; i < old.Count * 2; i++)
            {
                list.Add(new());
            }

            foreach (var entities in old)
            {
                foreach (var entity in entities)
                {
                    Put(entity.key, entity.value);
                }
            }
        }

        public void Remove(K key)
        {
            int hash = Math.Abs(key!.GetHashCode() % list.Count);
            var entities = list[hash];

            Entity target = null;

            foreach (var entity in entities)
            {
                if (entity.key!.Equals(key))
                {
                    target = entity;
                    break;
                }
            }

            if (target is not null)
            {
                entities.Remove(target);
                size -= 1;
            }
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append('{');
            foreach (var entities in list)
            {
                foreach (var entity in entities)
                {
                    stringBuilder.Append($"{entity.key}");
                    stringBuilder.Append($"=");
                    stringBuilder.Append($"{entity.value}");
                    stringBuilder.Append($",");
                }
            }
            stringBuilder.Append("}");

            return stringBuilder.ToString();
        }

        private class Entity
        {
            public K key;
            public V value;

            public Entity(K key, V value)
            {
                this.key = key;
                this.value = value;
            }
        }
    }
}