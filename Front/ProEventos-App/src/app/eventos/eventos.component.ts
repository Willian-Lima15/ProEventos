import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.css']
})
export class EventosComponent implements OnInit {


  public eventos: any = [];
  public eventosFiltrado: any = [];

  exibirImagem: boolean = true;
  private _filtroLista: string = "";

  public get filtroLista(){
    return this._filtroLista;
  }

  public set filtralisra(value: string){
     this._filtroLista = value;
     this.eventosFiltrado = this.filtroLista ? this.filtroEvento(this.filtroLista) : this.eventos;
  }

  filtroEvento(filtrarPor: string): any {
    filtrarPor = filtrarPor.toLocaleLowerCase();
    return this.eventos.filter(
      (evento: any) => evento.tema.toLocaleLowerCase().indexOf(filtrarPor) !== -1 ||
      evento.local.toLocaleLowerCase().indexOf(filtrarPor) !== -1
    )
  }

  constructor(
    private http: HttpClient
  ) { }

  ngOnInit() {
    this.getEventos();
  }

  alterarImagem(){
    this.exibirImagem = !this.exibirImagem
  }

  getEventos(){
    this.http.get("https://localhost:5001/api/Eventos").subscribe(
      res => {this.eventos = res;
        this.eventosFiltrado = this.eventos 
      }      
    )
  }

}
