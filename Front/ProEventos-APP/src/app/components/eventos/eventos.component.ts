
import { Component, OnInit, TemplateRef } from '@angular/core';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
// import { Evento } from '../models/Evento'; //TODO: aula 94 1:34 não sei ess aimportação abaixo está correta
import { Evento } from 'src/app/models/Evento';

import { EventoService } from 'src/app/services/evento.service';
import { ToastrService } from 'ngx-toastr';
import { NgxSpinnerService } from 'ngx-spinner';



@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss'],
  // providers:[EventoService]
})
export class EventosComponent implements OnInit {

ngOnInit(): void {
    
}
}
