import { Component, OnInit, TemplateRef } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { Medico } from '../models/medico';

@Component({
  selector: 'app-medico',
  templateUrl: './medico.component.html',
  styleUrls: ['./medico.component.css']
})
export class MedicoComponent implements OnInit {

  titleMedico = 'Médicos'

  public selectedMedico: Medico;
  public medicoForm: FormGroup;
  public modalRef: BsModalRef;
  

  public medicos = [
    {id:'1',nome:'Luiz',especialidade:'Cardiologista', crm:'987698759', telefone:'4342379867'},
    {id:'2',nome:'João',especialidade:'Clinico Geral', crm:'987698759', telefone:'4342379867'},
    {id:'3',nome:'Paulo',especialidade:'Psiquiatra', crm:'987698759', telefone:'4342379867'},
    {id:'4',nome:'Clebim',especialidade:'Podologista', crm:'987698759', telefone:'4342379867'},
    {id:'5',nome:'Chico',especialidade:'Otorino', crm:'987698759', telefone:'4342379867'}
  ]

  openModal(template: TemplateRef<any>) {
    this.modalRef = this.modalService.show(template)
  }

  creatForm(){
    this.medicoForm = this.fb.group({
      nome: ['',Validators.required],
      especialidade: ['',Validators.required],
      crm: ['',Validators.required],
      telefone: ['',Validators.required]
    })
  }

  selectMedico(medico: Medico){
    this.selectedMedico = medico;
    this.medicoForm.patchValue(medico)
  }

  back(){
    this.selectedMedico = null;
  }

  submit(){
    console.log(this.medicoForm.value)
  }
  
  constructor(private fb: FormBuilder, private modalService:BsModalService) {
    this.creatForm();
   }

  ngOnInit(): void {
  }

}
