using System.Collections.Generic;
using UnityEngine;

public class Chromosome : MonoBehaviour
{
    [SerializeField] int chromID; // The number of the chromosome for working with homologous pairs
    [SerializeField] float recombFreq; // This needs to be as the decimal value
    List<Gene> genes; // What genes does this specific chromosome have?

    public void Recombine(Chromosome other)
    {
        // Still debating if this is going to be a function inside of this class,
        // or if it will be handled by implementations of AbstractFlower.ProduceGametes
    }

}
