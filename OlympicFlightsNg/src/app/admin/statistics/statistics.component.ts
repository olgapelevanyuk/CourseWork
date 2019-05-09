import { Component, OnInit } from '@angular/core';
import { ChartService } from './charts/chartservice.service';
import * as Chart from 'chart.js';
import * as jsPDF from 'jspdf';
import { ChartData } from './charts/chartdata';

@Component({
  selector: 'app-statistics',
  templateUrl: './statistics.component.html',
  styleUrls: ['./statistics.component.css']
})
export class StatisticsComponent implements OnInit {

  constructor(private chartService: ChartService) { }

  flightMonthsChart: Chart;
  clientMonthsChart: Chart;
  ticketMonthsChart: Chart;
  overallStat: any;

  ngOnInit() {

    this.chartService.getOverallStatistics().subscribe(res => {
      this.overallStat = res;
      this.chartService.getFlightsPerMonthData().subscribe(res => {
        this.onInitFm('Completed and planned FLIGHTS FOR EACH MONTH', 'flightMonthsChart', res);

        this.chartService.getClientsPerMonthData().subscribe(res => {
          this.onInitCm('New clients per month', 'clientMonthsChart', res)
        
          this.chartService.getTicketsPerMonthData().subscribe(res => {
            this.onInitTm('Tickets bought per month', 'ticketMonthsChart', res)
          })
        })
      })
    });
  }

  onInitFm(title: string, selector: string, data: ChartData[]){
    this.flightMonthsChart = new Chart(selector, {
      type: 'line',
      data: {
        labels: data.map<string>(cd => cd.chartX),
        datasets: [
          {
            data: data.map<number>(cd => cd.chartY),
            borderColor: '#3cba9f',
            fill: true
          }
        ]
      },
      options: {
        title: {
          display: true,
          text: title,
          fontFamily: 'Roboto, sans-serif',
          fontColor: 'black',
          fontSize: 30
        },
        legend: {
          display: false
        },
        scales: {
          xAxes: [{
            display: true
          }],
          yAxes: [{
            display: true
          }],
        }
      }
    });
  }

  onInitCm(title: string, selector: string, data: ChartData[]){
    this.clientMonthsChart = new Chart(selector, {
      type: 'pie',
      data: {
        labels: data.map<string>(cd => cd.chartX),
        datasets: [
          {
            data: data.map<number>(cd => cd.chartY),
            backgroundColor: ['#e6194b', '#3cb44b', '#ffe119', '#4363d8', '#f58231', '#911eb4', '#46f0f0', '#f032e6', '#bcf60c', '#fabebe', '#008080', '#e6beff', '#9a6324'],
            fill: true
          }
        ]
      },
      options: {
        title: {
          display: true,
          text: title,
          fontFamily: 'Roboto, sans-serif',
          fontColor: 'black',
          fontSize: 30
        },
        legend: {
          display: true
        }
      }
    });
  }

  onInitTm(title: string, selector: string, data: ChartData[]){
    this.ticketMonthsChart = new Chart(selector, {
      type: 'line',
      data: {
        labels: data.map<string>(cd => cd.chartX),
        datasets: [
          {
            data: data.map<number>(cd => cd.chartY),
            borderColor: '#3cba9f',
            fill: true
          }
        ]
      },
      options: {
        title: {
          display: true,
          text: title,
          fontFamily: 'Roboto, sans-serif',
          fontColor: 'black',
          fontSize: 30
        },
        legend: {
          display: false
        },
        scales: {
          xAxes: [{
            display: true
          }],
          yAxes: [{
            display: true
          }],
        }
      }
    });
  }

  fmToPdf() {
    var doc = new jsPDF('landscape');

    var image = this.flightMonthsChart.toBase64Image();

    doc.addImage(image,'JPEG', 0, 0,280,200);
    doc.save('Statistics ' + Date.now());


  }
  cmToPdf() {
    var doc = new jsPDF('landscape');

    var image = this.clientMonthsChart.toBase64Image();

    doc.addImage(image,'PNG', 0, 0,240,200);
    doc.save('Statistics ' + Date.now());
  }
  tmToPdf() {
    var doc = new jsPDF('landscape');

    var image = this.ticketMonthsChart.toBase64Image();

    doc.addImage(image,'JPEG', 0, 0,280,200);
    doc.save('Statistics ' + Date.now());
  }

  onPrintStatistics(){
    var doc = new jsPDF('landscape');

    var currentdate = new Date();

    doc.setFontSize(20);
    doc.text('Overall statistics for ' + currentdate.toDateString() + ' '+ currentdate.toLocaleTimeString(),19,19);
    doc.setLineWidth(1);
    doc.line(20, 20, 180, 20) // horizontal line
    doc.text('Overall users: ' + this.overallStat.overallUsers,21,39);
    doc.text('Overall clients: ' + this.overallStat.overallClients,21,59);
    doc.text('Overall flights: ' + this.overallStat.overallFlights,21,79);
    doc.text('Overall countries: ' + this.overallStat.overallCountries,21,99);
    doc.text('Overall profit: ' + this.overallStat.overallProfit,21,119);
    doc.text('Overall incoming profit: ' + this.overallStat.incomintProfit,21,139);
    doc.save('Report ' + Date.now());

    // var fm = this.flightMonthsChart.toBase64Image();
    // var tm = this.ticketMonthsChart.toBase64Image();
    // var cm = this.clientMonthsChart.toBase64Image();

    // doc.addImage(fm,'JPEG', 0, 0,280,200);
    // doc.addPage('a3', 'portrait');
    // doc.addImage(tm,'JPEG', 0, 0,280,200);
    // doc.addPage('a3', 'portrait');
    // doc.addImage(cm,'JPEG', 0, 0,280,200);

    // doc.save('FullReport ' + Date.now());
  }

}
