import { Component, OnInit } from '@angular/core';
import { Router, RouterEvent } from '@angular/router';
import { Platform } from '@ionic/angular';

@Component({
  selector: 'app-sidenav',
  templateUrl: './sidenav.page.html',
  styleUrls: ['./sidenav.page.scss'],
})
export class SidenavPage implements OnInit {

  navigate : any;

  sideMenu(){
  this.navigate = [
    {
      name: 'Media',
      link: '/nav/media',
      icon: 'person-circle'
    },
    {
      name: 'Calender',
      link: '/nav/calender',
      icon: 'person-circle'
    },
    {
      name: 'Forums',
      link: '/nav/forums',
      icon: 'person-circle'
    },
    {
      name: 'Messages',
      link: '/nav/messages',
      icon: 'person-circle'
    },
    {
      name: 'Profile',
      link: '/nav/profile',
      icon: 'person-circle'
    }
  ];
}

  constructor(private route : Router) {
    this.sideMenu();
  }

  ngOnInit() {
  }

  nextPage(str){
    this.route.navigate(['../'+str]);
  }

}
