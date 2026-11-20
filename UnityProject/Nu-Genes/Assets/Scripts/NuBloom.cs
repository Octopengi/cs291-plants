using UnityEngine;

public class NuBloom : AbstractFlower
{
    [Header("Phenotypes")]
    string leafShape; string height;
    string placement; string color;
    string spots;

    void Awake() {
        speciesName = "NuBloom";
        chroms = new Chromosome[5, 2];
    }

    protected override void DeterminePhenotypes() {
        throw new System.NotImplementedException();
    }

    protected override Gamete ProduceGametes() {
        throw new System.NotImplementedException();
    }
}