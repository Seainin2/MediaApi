import { Component, OnInit } from '@angular/core';
import { FireserviceService } from 'src/app/services/fireservice.service';
import { NavController } from '@ionic/angular';

@Component({
  selector: 'app-signup',
  templateUrl: './signup.page.html',
  styleUrls: ['./signup.page.scss'],
})
export class SignupPage implements OnInit {
  public email:any;
  public password:any;
  public name:any;


  constructor(public fireService:FireserviceService,private navCtrl:NavController) { }

  ngOnInit() {
  }

  signup(){
    this.fireService.signup({email:this.email,password:this.password}).then(res=>{
      if(res.user.uid){
        let data = {
          email:this.email,
          password:this.password,
          name:this.name,
          uid:res.user.uid
        }
        this.fireService.saveDetails(data).then(res=>{
          alert('Account Created!');
          this.navCtrl.navigateForward('login')
        })
      }
    },err=>{
      alert(err.message);
    }
  )}

}
