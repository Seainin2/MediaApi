import { Component, OnInit } from '@angular/core';
import { Router, RouterEvent } from '@angular/router';

@Component({
  selector: 'app-sidenav',
  templateUrl: './sidenav.page.html',
  styleUrls: ['./sidenav.page.scss'],
})
export class SidenavPage implements OnInit {

  active = '';

  NAV = [
    {
      name: 'Media',
      link: 'media-tabs',
      icon: 'person-circle'
    },
    {
      name: 'Calender',
      link: 'calender',
      icon: 'person-circle'
    },
    {
      name: 'Forums',
      link: 'forums',
      icon: 'person-circle'
    },
    {
      name: 'Friends',
      link: 'friends',
      icon: 'person-circle'
    },
    {
      name: 'Profile',
      link: 'profile',
      icon: 'person-circle'
    }
  ]

  constructor(private router: Router) {
    this.router.events.subscribe((event: RouterEvent) =>
    {
      this.active = event.url
    })

  }

  ngOnInit() {
  }

}
