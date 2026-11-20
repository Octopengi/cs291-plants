using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractFlower : MonoBehaviour
{
    protected Chromosome[,] chroms;
    protected string speciesName; // This variable should be set in a child class of AbstractFlower
    public string SpeciesName { get {return speciesName;} } //Nothing is allowed to change the species name

    protected abstract void DeterminePhenotypes();
    protected abstract Gamete ProduceGametes();
}
