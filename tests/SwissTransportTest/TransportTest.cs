﻿namespace SwissTransport
{
    using FluentAssertions;
    using SwissTransport.Core;
    using SwissTransport.Models;
    using System;
    using Xunit;

    public class TransportTest
    {
        private readonly ITransport testee;

        public TransportTest()
        {
            this.testee = new Transport();
        }

        [Fact]
        public void Locations()
        {
            Stations stations = this.testee.GetStations("Sursee,");

            stations.StationList.Should().HaveCount(10);
        }

        [Fact]
        public void StationBoard()
        {
            StationBoardRoot stationBoard = this.testee.GetStationBoard("Sursee", "8502007");

            stationBoard.Should().NotBeNull();
        }

        [Fact]
        public void Connections()
        {
            Connections connections = this.testee.GetConnections("Sursee", "Luzern");

            connections.Should().NotBeNull();
        }

        [Fact]
        public void Connections2()
        {
            Connections connections = this.testee.GetConnectionsByTime("Sursee", "Luzern", 4, DateTime.Now.Date, Convert.ToDateTime(DateTime.Now.ToString("h:mm:ss tt")));

            connections.Should().NotBeNull();
        }
    }
}