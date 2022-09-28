
import { Component, OnInit, TemplateRef } from '@angular/core';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { Evento } from '../models/Evento';
import { EventoService } from '../services/evento.service';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss'],
  // providers:[EventoService]
})
export class EventosComponent implements OnInit {

  modalRef = {} as BsModalRef;
  public eventos: Evento[] = [];
  // public eventosFiltrados: any= [];
  public eventosFiltrados: Evento[] = []; //aula 85 porém não roda deixei conforme aicma

  public larguraImagem = 150;
  public margemImagem = 2;
  public exibirImagem = true;
  private filtroListado = '';


  public get filtroLista(): string
  {
    return this.filtroListado;
  }

  public set filtroLista(value: string)
  {
     this.filtroListado =value;
     this.eventosFiltrados=this.filtroLista? this.filtrarEventos(this.filtroLista): this.eventos

  }

  public  filtrarEventos(filtrarPor: string): Evento[] {
    filtrarPor=filtrarPor.toLocaleLowerCase();
    return this.eventos.filter(
      (evento:{tema: string; local: string;}) => evento.tema.toLocaleLowerCase().indexOf(filtrarPor) ! == -1 ||
      evento.local.toLocaleLowerCase().indexOf(filtrarPor) ! == -1
    );
  }

  constructor(
    private eventoService: EventoService,
    private modalService: BsModalService,
    private toastr: ToastrService
    ) { }

  public ngOnInit(): void {
    this.getEventos();
  }

  public alterarImagem(): void {
    this.exibirImagem=!this.exibirImagem;
  }

  public getEventos(): void{
    this.eventoService.getEventos().subscribe({
      next: (eventos: Evento[])=> {
      this.eventos=eventos;
      this.eventosFiltrados= this.eventos;
      },
      error: error=>console.log(error)
    });
  }

  //aula 85 pelo final
  // public getEventos1(): void{

  //   this.eventoService.getEventos().subscribe(
  //     (eventos: Evento[])=>{
  //       this.eventos=eventos;
  //       this.eventosFiltrados= this.eventos;
  //     },
  //     error=>console.log(error)
  //   );
  // }

  public openModal(template: TemplateRef<any>): void {
    this.modalRef = this.modalService.show(template, {class: 'modal-sm'});
  }

  public confirm(): void {
    this.modalRef.hide();
    this.toastr.success('O evento foi excuido com sucesso!', 'Deletado!');
  }

  public decline(): void {
    this.modalRef.hide();
  }

}
