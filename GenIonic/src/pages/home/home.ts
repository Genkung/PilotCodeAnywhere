import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import { HttpClient } from '@angular/common/http';
import { HttpHeaders } from '@angular/common/http';


@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {
  resultFromAPI: any;
  constructor(public navCtrl: NavController, private http: HttpClient) {

  }
  Calculate(valueFirst:number, valueSecond:number)
  {
      let option = {headers: new HttpHeaders({ 'Content-Type': 'application/json' })};
      
  }
  TestPost()
  {
      let option = {headers: new HttpHeaders({ 'Content-Type': 'application/json' })};
      this.http.post(GlobalVarible.host + "/api/Shop/Create", JSON.stringify(this.Model), option)
      .subscribe(data => {
        this.navCtrl.pop();
      });
  }
  }

}
