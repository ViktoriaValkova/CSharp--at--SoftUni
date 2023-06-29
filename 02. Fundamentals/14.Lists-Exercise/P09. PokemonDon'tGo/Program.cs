namespace P09._PokemonDon_tGo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> pokemons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int sumRemovedElements = 0;
            while (pokemons.Count > 0)
            {
                int currentPokemonIndex = int.Parse(Console.ReadLine());

                if (currentPokemonIndex < 0)
                {
                    // remove the first element of the sequence, and copy the last element to its pla
                    sumRemovedElements += pokemons[0];
                    ReplaceFirstElementWithLast(pokemons);
                }
                else if (currentPokemonIndex >= pokemons.Count)
                {
                    sumRemovedElements += pokemons[pokemons.Count - 1];
                    //remove the last element from the sequence, and copy the first element to its place.
                    ReplaceLastElementWithFirst(pokemons);
                }
                else
                {
                    sumRemovedElements += pokemons[currentPokemonIndex];
                    ChangeElementValue(pokemons, pokemons[currentPokemonIndex]);
                    pokemons.RemoveAt(currentPokemonIndex);
                }
            }

            Console.WriteLine(sumRemovedElements);
        }

        static void ReplaceFirstElementWithLast(List<int> pokemons)
        {
            int firstElement = pokemons[0];
            int lastElement = pokemons[pokemons.Count - 1];
            pokemons[0] = lastElement;

            ChangeElementValue(pokemons, firstElement);
        }
        static void ReplaceLastElementWithFirst(List<int> pokemons)
        {
            int firstElement = pokemons[0];
            int lastElement = pokemons[pokemons.Count - 1];
            pokemons[pokemons.Count - 1] = firstElement;

            ChangeElementValue(pokemons, lastElement);
        }
        static void ChangeElementValue(List<int> pokemons, int currentElement)
        {
            for (int i = 0; i < pokemons.Count; i++)
            {
                if (pokemons[i] <= currentElement)
                {
                    pokemons[i] += currentElement;
                }
                else
                {
                    pokemons[i] -= currentElement;
                }
            }
        }
    }
}