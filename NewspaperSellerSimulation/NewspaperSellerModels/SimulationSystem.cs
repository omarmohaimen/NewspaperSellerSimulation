using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperSellerModels
{
    public class SimulationSystem
    {
        public SimulationSystem()
        {
            DayTypeDistributions = new List<DayTypeDistribution>();
            DemandDistributions = new List<DemandDistribution>();
            SimulationTable = new List<SimulationCase>();
            PerformanceMeasures = new PerformanceMeasures();
        }
        ///////////// INPUTS /////////////
        public int NumOfNewspapers { get; set; }
        public int NumOfRecords { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal ScrapPrice { get; set; }
        public decimal UnitProfit { get; set; }
        public List<DayTypeDistribution> DayTypeDistributions { get; set; }
        public List<DemandDistribution> DemandDistributions { get; set; }

        ///////////// OUTPUTS /////////////
        public List<SimulationCase> SimulationTable { get; set; }
        public PerformanceMeasures PerformanceMeasures { get; set; }

        //Random instance
        Random random = new Random();


        public void fillTypeOfNewsDay(List<decimal> probability)
        {

            DayTypeDistributions.Add(new DayTypeDistribution());
            DayTypeDistributions[0].Probability = probability[0];
            DayTypeDistributions[0].CummProbability = DayTypeDistributions[0].Probability;
            DayTypeDistributions[0].MinRange = 1;
            DayTypeDistributions[0].MaxRange = (int)((DayTypeDistributions[0].CummProbability * 100));
            for (int i = 1; i < 3; i++)
            {
                DayTypeDistributions.Add(new DayTypeDistribution());
                DayTypeDistributions[i].Probability = probability[i];
                DayTypeDistributions[i].CummProbability = DayTypeDistributions[i - 1].CummProbability + DayTypeDistributions[i].Probability;
                DayTypeDistributions[i].MinRange = (int)((DayTypeDistributions[i - 1].CummProbability * 100) + 1);
                DayTypeDistributions[i].MaxRange = (int)((DayTypeDistributions[i].CummProbability * 100));

            }
            DayTypeDistributions[0].DayType = Enums.DayType.Good;
            DayTypeDistributions[1].DayType = Enums.DayType.Fair;
            DayTypeDistributions[2].DayType = Enums.DayType.Poor;


        }

        public void fillDemandDistribution(List<int> demand, List<decimal> goodprobability, List<decimal> fairprobability, List<decimal> poorprobability)
        {
            DemandDistributions.Add(new DemandDistribution());
            DemandDistributions[0].Demand = demand[0];
            int len = demand.Count;
            for (int i = 0; i < 3; i++)
            {
                DemandDistributions[0].DayTypeDistributions.Add(new DayTypeDistribution());

                decimal prob;
                if (i == 0)
                {
                    prob = goodprobability[0];
                    DemandDistributions[0].DayTypeDistributions[i].DayType = Enums.DayType.Good;

                }
                else if (i == 1)
                {
                    prob = fairprobability[0];
                    DemandDistributions[0].DayTypeDistributions[i].DayType = Enums.DayType.Fair;

                }
                else
                {
                    prob = poorprobability[0];
                    DemandDistributions[0].DayTypeDistributions[i].DayType = Enums.DayType.Poor;

                }
                DemandDistributions[0].DayTypeDistributions[i].Probability = prob;
                DemandDistributions[0].DayTypeDistributions[i].CummProbability = DemandDistributions[0].DayTypeDistributions[i].Probability;
                DemandDistributions[0].DayTypeDistributions[i].MinRange = 1;
                DemandDistributions[0].DayTypeDistributions[i].MaxRange = (int)((DemandDistributions[0].DayTypeDistributions[i].CummProbability * 100));
            }
           for (int j = 1; j < len; j++)
            {
                DemandDistributions.Add(new DemandDistribution());
                DemandDistributions[j].Demand = demand[j];

                for (int i = 0; i < 3; i++)
                {
                    DemandDistributions[j].DayTypeDistributions.Add(new DayTypeDistribution());

                    decimal prob;
                    if (i == 0)
                    {
                        prob = goodprobability[j];
                        DemandDistributions[j].DayTypeDistributions[i].DayType = Enums.DayType.Good;

                    }
                    else if (i == 1)
                    {
                        prob = fairprobability[j];
                        DemandDistributions[j].DayTypeDistributions[i].DayType = Enums.DayType.Fair;

                    }
                    else
                    {
                        prob = poorprobability[j];
                        DemandDistributions[j].DayTypeDistributions[i].DayType = Enums.DayType.Poor;
                        
                    }
                    DemandDistributions[j].DayTypeDistributions[i].Probability = prob;
                    DemandDistributions[j].DayTypeDistributions[i].CummProbability = DemandDistributions[j-1].DayTypeDistributions[i].CummProbability + DemandDistributions[j].DayTypeDistributions[i].Probability;
                    DemandDistributions[j].DayTypeDistributions[i].MinRange = (int)((DemandDistributions[j-1].DayTypeDistributions[i].CummProbability * 100) + 1);
                    DemandDistributions[j].DayTypeDistributions[i].MaxRange = (int)((DemandDistributions[j].DayTypeDistributions[i].CummProbability * 100));


                }
            }


        }

        private Enums.DayType Get_type_of_newDay(int RandomNewsDayType)
        {
            int len = DayTypeDistributions.Count;
            for (int  i = 0; i<len; i++)
            {
                if(RandomNewsDayType>=DayTypeDistributions[i].MinRange &&RandomNewsDayType<=DayTypeDistributions[i].MaxRange)
                {
                    return DayTypeDistributions[i].DayType;
                }
            }
            return 0;
        }
        private int Get_Demand_value(int RandomDemand, Enums.DayType type)
        {
            int len = DemandDistributions.Count;
            int t = 0;
            for (int j = 0; j < 3; j++)
            {
                if (DemandDistributions[0].DayTypeDistributions[j].DayType == type)
                {
                    t = j;
                }
            }
            for (int i = 0; i < len; i++)
            {
                if(RandomDemand>=DemandDistributions[i].DayTypeDistributions[t].MinRange && RandomDemand <= DemandDistributions[i].DayTypeDistributions[t].MaxRange)
                {
                    return DemandDistributions[i].Demand;

                }
            }
            return 0;
        } 
        public void fillSimulationTable()
        {
            

            for(int i = 0; i< NumOfRecords; i ++)
            {
                SimulationTable.Add(new SimulationCase());
                SimulationTable[i].DayNo = i + 1;
                SimulationTable[i].RandomNewsDayType = random.Next(1, 101);
                SimulationTable[i].NewsDayType = Get_type_of_newDay(SimulationTable[i].RandomNewsDayType);
                SimulationTable[i].RandomDemand = random.Next(1, 101);
                SimulationTable[i].Demand = Get_Demand_value(SimulationTable[i].RandomDemand, SimulationTable[i].NewsDayType);
                int sellAmount = SimulationTable[i].Demand > NumOfNewspapers ? NumOfNewspapers : SimulationTable[i].Demand;
                SimulationTable[i].SalesProfit = sellAmount * SellingPrice;
                decimal net_profit = SellingPrice - PurchasePrice;
                SimulationTable[i].LostProfit =  ((SimulationTable[i].Demand - NumOfNewspapers) > 0) ? (SimulationTable[i].Demand - NumOfNewspapers)* net_profit: 0;
                SimulationTable[i].ScrapProfit = ((NumOfNewspapers - SimulationTable[i].Demand) > 0) ? (NumOfNewspapers - SimulationTable[i].Demand) * ScrapPrice : 0;
                SimulationTable[i].DailyNetProfit = (SimulationTable[i].SalesProfit - (NumOfNewspapers * PurchasePrice) - SimulationTable[i].LostProfit + SimulationTable[i].ScrapProfit);
                SimulationTable[i].DailyCost = NumOfNewspapers * PurchasePrice;

            }


     
        }
        public void fillPerformanceMeasure()
        {
            for (int i = 0; i < NumOfRecords; i++)
            {
                PerformanceMeasures.TotalSalesProfit += SimulationTable[i].SalesProfit;
                PerformanceMeasures.TotalLostProfit += SimulationTable[i].LostProfit;
                PerformanceMeasures.TotalScrapProfit += SimulationTable[i].ScrapProfit;
                PerformanceMeasures.TotalNetProfit += SimulationTable[i].DailyNetProfit;
                if (SimulationTable[i].LostProfit != 0)
                    PerformanceMeasures.DaysWithMoreDemand++;
                if (SimulationTable[i].ScrapProfit != 0)
                    PerformanceMeasures.DaysWithUnsoldPapers++;

            }
            PerformanceMeasures.TotalCost = NumOfRecords*(NumOfNewspapers * PurchasePrice);

        }

    }
}
