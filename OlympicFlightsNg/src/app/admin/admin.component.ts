import { Component, OnInit, ViewChild } from '@angular/core';
import { TicketService } from '../tickets-management/service/ticket.service';
import { Ticket } from '../tickets-management/models/ticket';
import { MatSort, MatTableDataSource } from '@angular/material';
import { ToastrService } from 'ngx-toastr';
import { Router, ActivatedRoute } from '@angular/router';


@Component({
  selector: 'app-admin',
  templateUrl: './admin.component.html',
  styleUrls: ['./admin.component.css']
})
export class AdminComponent implements OnInit {

  dataSource: MatTableDataSource<Ticket>;
  tickets: Ticket[];
  displayedColumns: string[];

  constructor(private ticketService: TicketService,
    private toastr: ToastrService,
    private route: Router,
    private router:ActivatedRoute) { }

  @ViewChild(MatSort) sort: MatSort;

  applyFilter(filterValue: string) {
    this.dataSource.filter = filterValue.trim().toLowerCase();
  }

  ngOnInit() {
    this.ticketService.getTickets().subscribe(res => {
      this.tickets = res;
      this.displayedColumns = ['ticketId', 'clientId', 'flightId', 'created', 'approve'];
      this.dataSource = new MatTableDataSource(res.filter(t => !t.isPurchaseApproved));
      this.dataSource.sort = this.sort;

    });
    
  }

  onApprove(ticketId: number) {
    this.ticketService.approveTicket(ticketId).subscribe((res: any) => {
      if (res.successMessage !== null) {
        this.toastr.success(res.successMessage, 'Success');
        this.dataSource.data = this.dataSource.data.filter(t => t.ticketId !== ticketId);
        
        return;
      }
      if (res.errorMessage !== null) {
        this.toastr.error(res.errorMessage, 'Error');
      }
    });
  }




  // onSaveChartToPdf(chartToSave: Chart, chartTitle: string) {
  //   var doc = new jsPDF();

  //   var image = chartToSave.toBase64Image();

  //   doc.addImage(image, 'a4', 0, 0);
  //   doc.save(chartTitle);
  // }
  // saveMCChartToPdf() {
  //   this.onSaveChartToPdf(this.clientMonthsChart, 'Clients per month chart');
  // }

}
