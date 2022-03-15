import { MovieService} from '../../../../services/movie.service';
import { Component, OnInit } from '@angular/core';
import { Movies } from '../../../../interfaces/all';
import { NavigationExtras, Router } from '@angular/router';
import { Observable } from 'rxjs';
import { LoadingController, NavController, Platform } from '@ionic/angular';
import { HttpClient } from '@angular/common/http';
import { finalize } from 'rxjs/operators';

@Component({
  selector: 'app-movies',
  templateUrl: './movies.page.html',
  styleUrls: ['./movies.page.scss'],
})
export class MoviesPage{

  data = [];
  results: Observable<any>;

  constructor(public navCtrl: NavController, public httpClient: HttpClient,private plt: Platform, private loadingCtrl: LoadingController) { }

  ngOnInit() {
  }

  async searchDataFuckCors(){
    let loading = await this.loadingCtrl.create();
    await loading.present();

    this.httpClient.get('http://localhost:5000/api/movies').pipe(
      finalize(() => loading.dismiss())
    )
    .subscribe(data => {
      this.data = data[0];
    }, err => {
      console.log('JS Call error: ',err);
    })

  }

  searchData(){
    this.results = this.httpClient.get('http://localhost:5000/api/movies');
    this.results
    .subscribe(data => {
      console.log('my data: ', data);
    })
  }

}