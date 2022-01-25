import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class EmpService {

info1: string[]=["Kiran", "101", "kiran@gmail.com"]
info2: string[]=["Ravi", "102", "ravi@gmail.com"]
info3: string[]=["Ramu", "103", "ramu@gmail.com"]

getinfo1(): string[]{
  return this.info1
}
getinfo2(): string[]{
  return this.info2
}
getinfo3(): string[]{
  return this.info3
}

  constructor() { }
}
