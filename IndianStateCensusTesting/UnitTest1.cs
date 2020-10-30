using NUnit.Framework;
using IndianStateCensusAnalyzer;
using System.Collections.Generic;
using IndianStateCensusAnalyzer.DTO;
using static IndianStateCensusAnalyzer.CensusAnalyser;


namespace IndianStateCensusTesting
{
    public class Tests
    {
        static string indianStateCensusHeaders = "State,Population,AreaInSqKm,DensityPerSqKm";
        static string indianStateCodeHeaders = "SrNo,State Name,TIN,StateCode";
        static string indianStateCensusFilePath = @"C:\Users\saura\Desktop\Training\IndianStateCensusAnalyzer\IndianStateCensusAnalyzer\CSVFiles\IndiaStateCensusData.csv";
        static string delimiterIndianCensusFilePath = @"C:\Users\saura\Desktop\Training\IndianStateCensusAnalyzer\IndianStateCensusAnalyzer\CSVFiles\DelimiterIndiaStateCensusData.csv";
        static string wrongIndianStateCensusFilePath = @"C:\Users\saura\Desktop\Training\practice\IndianState\NUnitTestProject1\CSVFile\WrongIndiaStateCensusData.csv";
        static string wrongIndianStateCensusFileType = @"C:\Users\saura\Desktop\Training\IndianStateCensusAnalyzer\IndianStateCensusAnalyzer\CSVFiles\IndiaStateCensusData.txt";
        
        CensusAnalyser censusAnalyser;
        Dictionary<string, CensusDTO> stateRecord;

        [SetUp]
        public void Setup()
        {
            censusAnalyser = new CensusAnalyser();
            stateRecord = new Dictionary<string, CensusDTO>();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void GivenIndianCensusDataFile_WhenReaded_ShouldReturnCensusDataCount()
        {
            stateRecord = censusAnalyser.LoadCensusData(indianStateCensusFilePath, Country.INDIA, indianStateCodeHeaders);
            Assert.AreEqual(29, stateRecord.Count);
        }

    }
}