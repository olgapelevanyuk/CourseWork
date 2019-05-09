import { Component, OnInit, ViewChild } from '@angular/core';
import { TicketService } from '../../service/ticket.service';
import { Ticket } from '../../models/ticket';
import { MatTableDataSource, MatSort } from '@angular/material';
import { ActivatedRoute, Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { ClientService } from 'src/app/client-management/client.service';

@Component({
  selector: 'app-ticket-list',
  templateUrl: './ticket-list.component.html',
  styleUrls: ['./ticket-list.component.css']
})
export class TicketListComponent implements OnInit {
  displayedColumns: string[];
  dataSource: MatTableDataSource<Ticket>;
  tickets: Ticket[];
  

  constructor(private ticketService: TicketService,
    private toastr: ToastrService,
    private route: Router,
    private router:ActivatedRoute,
    private clientService: ClientService
  ) { }
  
  @ViewChild(MatSort) sort: MatSort;


  applyFilter(filterValue: string) {
    this.dataSource.filter = filterValue.trim().toLowerCase();
  }

  ngOnInit() {
    this.ticketService.getTickets().subscribe(res => {

    this.tickets = res;
    this.clientService.getClients().subscribe(cls => {
      this.tickets.forEach(t => t.client = cls.find(cl => cl.clientId == t.clientId));
    })
      this.displayedColumns = ['ticketId', 'clientId', 'flightId', 'created', 'approve','actions'];
      this.dataSource = new MatTableDataSource(res);
      this.dataSource.sort = this.sort;
    });
  }

  // onDelete(ticketId: number) {
  //   this.ticketService.setTicketStatus(ticketId, true).subscribe(res => {
  //     this.tickets.find(t => t.ticketId === ticketId).isDeleted = true;
  //     this.dataSource.data = this.tickets;
  //   });
  // }

  onPurge(ticketId: number) {
    this.ticketService.deleteTicketById(ticketId).subscribe((res:any) => {
      if(res.successMessage !== null){
        this.toastr.success(res.successMessage, 'Success');
      }
      this.dataSource.data = this.dataSource.data.filter(t => t.ticketId !== ticketId);
    });
  }

  onApproveTickets() {
    const ticketIds = this.tickets.filter(t => !t.isPurchaseApproved).map<number>(tm => tm.ticketId);

    this.ticketService.approveTickets(ticketIds).subscribe(res => {
      this.tickets.forEach((element) => {
        element.isPurchaseApproved = true;
      });
    });
  }

  onApprove(ticketId: number) {
    this.ticketService.approveTicket(ticketId).subscribe((res: any) => {
      if (res.successMessage !== null) {
        this.toastr.success(res.successMessage, 'Success');
        this.dataSource.data.find(t => t.ticketId === ticketId).isPurchaseApproved =true;
        return;
      }
      if (res.errorMessage !== null) {
        this.toastr.error(res.errorMessage, 'Error');
      }
    });
  }

  // onRestore(ticketId: number) {
  //   this.ticketService.setTicketStatus(ticketId, false).subscribe(res => {
  //     this.tickets.find(t => t.ticketId === ticketId).isDeleted = false;
  //   });
  // }
}
