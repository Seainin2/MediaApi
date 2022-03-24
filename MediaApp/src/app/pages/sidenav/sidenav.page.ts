import { Component, OnInit } from '@angular/core';
import { Router, RouterEvent } from '@angular/router';
import { MenuController, NavController, Platform } from '@ionic/angular';

@Component({
  selector: 'app-sidenav',
  templateUrl: './sidenav.page.html',
  styleUrls: ['./sidenav.page.scss'],
})
export class SidenavPage implements OnInit {
  page: string;
 

  constructor(private route:Router)  {

  }

  ngOnInit() {
  }

  goToPage(page){
  }

  //navigate(){
  //  this.route.navigate()
  //}

}
