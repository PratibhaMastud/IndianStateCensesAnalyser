using IndianStateCensesAnalyser;
using IndianStateCensesAnalyser.DTO;
using NUnit.Framework;
using System.Collections.Generic;
using static IndianStateCensesAnalyser.CensusAnalyser;

namespace IndianStateCensusAnalyserTest
{
    public class TestClass
    {

        static string indianStateCensusHeaders = "﻿State,Population,AreaInSqKm,DensityPerSqKm";
        static string indianStateCensusFilePath = @"C:\Users\prattii\Desktop\IndianStatesAnalyserProject\IndianStateCensesAnalyser\IndianStateCensusAnalyserTest\CsvFiles\IndianStateCensusData.csv";

        CensusAnalyser censusAnalyser;
        Dictionary<string, CensusDTO> totalRecord;

        [SetUp]
        public void Setup()
        {
            censusAnalyser = new CensusAnalyser();
            totalRecord = new Dictionary<string, CensusDTO>();
        }

        /// <summary>
        /// Test Case 1.1 Given the indian census data file when reader should return census data count.
        /// </summary>
        [Test]
        public void GivenIndianCensusDataFile_WhenReade_ThenShouldReturnCensusDataCount()
        {
            totalRecord = censusAnalyser.LoadCensusData(Country.INDIA, indianStateCensusFilePath, indianStateCensusHeaders);
            Assert.AreEqual(29, totalRecord.Count);
        }
    }
}