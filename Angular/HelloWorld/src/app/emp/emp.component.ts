import { Component, OnInit } from '@angular/core';
import {EmpService} from "../emp.service";

@Component({
  selector: 'app-emp',
  templateUrl: './emp.component.html',
  styleUrls: ['./emp.component.css'],
  providers: [EmpService]
})
export class EmpComponent implements OnInit {

  infoReceived1: string[]=[];
  infoReceived2: string[]=[];
  infoReceived3: string[]=[];

  getinfofromserviceclass1(){

    this.infoReceived1= this.empservice.getinfo1();
  }
getinfofromsericeclass2(){
  this.infoReceived2=this.empservice.getinfo2();
}
getinfofromserviceclass3(){
  this.infoReceived3=this.empservice.getinfo3();
}
  constructor(private empservice:EmpService) { }

  ngOnInit(): void {
  }

}
