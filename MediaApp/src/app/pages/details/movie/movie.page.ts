import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-movie',
  templateUrl: './movie.page.html',
  styleUrls: ['./movie.page.scss'],
})
export class MoviePage implements OnInit {

  data: any;
  apidata: any;
  results: Observable<any>;

  url = "http://localhost:5000/api/Series/";

  constructor(private route: ActivatedRoute, private router: Router, private httpClient: HttpClient) {
    this.route.queryParams.subscribe(params => {
      if(this.router.getCurrentNavigation().extras.state){
        this.data = this.router.getCurrentNavigation().extras.state.media
      }
    }

    )
  }

  ngOnInit() {
    this.results = this.httpClient.get(`${this.url}${this.data.seriesId}`);
    this.results
    .subscribe(apidata => {
      this.apidata = apidata;
      console.log('my data: ', apidata);
    })
  }

}
