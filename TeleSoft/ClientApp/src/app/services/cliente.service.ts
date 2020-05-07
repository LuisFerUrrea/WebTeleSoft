import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { ClienteModel } from '../models/cliente.model';
import { MyResponseModel } from '../models/myresponse.model';


const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type': 'application/json',
    'Authorization': 'my-auth-token'
  })
}

@Injectable({
  providedIn: 'root'  
})
export class ClienteService {

  public baseUrl: string;

  constructor(protected http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.baseUrl = baseUrl;
  }

  public GetClientes(): Observable<ClienteModel[]> { 
    return this.http.get<ClienteModel[]>(this.baseUrl + "Cliente/GetAll");
  }

  public GetCliente(id): Observable<ClienteModel> {
    return this.http.get<ClienteModel>(this.baseUrl + "Cliente/Get?id=" + id);
  }

  public Add(cliente: ClienteModel): Observable<ClienteModel> {   
    //return this.http.post<ClienteModel>(this.baseUrl + "Cliente/AddCliente", { 'nombre': cliente.nombre, 'correo': cliente.correo, 'tipoAlmacenamiento': cliente.tipoAlmacenamiento }, httpOptions);
    return this.http.post<ClienteModel>(this.baseUrl + "Cliente/AddCliente", cliente, httpOptions);
    //subscribe(result => {
    // return result;
    //},
    //  error => console.error(error)
    //);
  }

  public Update(cliente: ClienteModel): Observable<ClienteModel> {   
    //return this.http.put<ClienteModel>(this.baseUrl + "Cliente/UpdateCliente", { 'id': cliente.id, 'nombre': cliente.nombre, 'correo': cliente.correo, 'tipoAlmacenamiento': cliente.tipoAlmacenamiento }, httpOptions);
    return this.http.put<ClienteModel>(this.baseUrl + "Cliente/UpdateCliente", cliente , httpOptions);
    //subscribe(result => {
    // return result;
    //},
    //  error => console.error(error)
    //);
  }

  public delete(cliente: ClienteModel) {
    console.log("delete cliente"+ cliente.id.toString());
    return this.http.delete<ClienteModel>(this.baseUrl + "Cliente/DeleteCliente?id=" + cliente.id).
      subscribe(result => {
        console.log(result);
      },
        error => console.error(error)
      );
  }

}
