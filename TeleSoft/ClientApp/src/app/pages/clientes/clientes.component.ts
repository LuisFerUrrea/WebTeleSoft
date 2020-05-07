import { Component, OnInit, ViewChild } from '@angular/core';
import { ClienteModel } from '../../models/cliente.model';
import { MatPaginator, MatSort, MatTableDataSource } from '@angular/material';
import { ClienteService } from '../../services/cliente.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-clientes',
  templateUrl: './clientes.component.html'
})
export class ClientesComponent implements OnInit {

  cliente: ClienteModel;
  clientes: ClienteModel[] = [];
  dataSource = null;
  cargando = false;
  displayedColumns: string[] = ['id', 'nombre', 'correo', 'acciones'];

  @ViewChild(MatPaginator, { static: true }) paginator: MatPaginator;
  @ViewChild(MatSort, { static: true }) sort: MatSort;



  constructor(private clienteService: ClienteService) { }


  ngOnInit() {
    this.cargando = true;
    this.clienteService.GetClientes()
      .subscribe(resp => {        
        this.dataSource = new MatTableDataSource<ClienteModel>(resp);
        this.dataSource.paginator = this.paginator;
        this.dataSource.sort = this.sort;       
      });
  }


  borrarCliente(cliente: ClienteModel, i: number) {
    Swal.fire({
      title: '¿Esta seguro?',
      text: `Esta seguro que desea borrar a ${cliente.nombre}`,
      icon: 'question',
      showConfirmButton: true,
      showCancelButton: true

    }).then(resp => {
      if (resp.value) {       
        this.clienteService.delete(cliente);
        //let i: number = this.dataSource.data.findIndex(d => d.id === cliente.id);
        this.dataSource.data.splice(i, 1)       
        this.dataSource = new MatTableDataSource<ClienteModel>(this.dataSource.data);
      }
    });


  }

}
