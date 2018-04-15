import { Component } from '@angular/core';

import { NavController } from 'ionic-angular';
import { NavParams } from 'ionic-angular';
import { siteMap } from '../../app/app.modules-base';
import { IonicBase } from '../../app/ionic-base';
import { RestAPIService } from '../../providers/rest-api-service';
import { Observable } from 'rxjs/Observable';
import { Subject } from "rxjs/Subject";
import { Storage } from '@ionic/storage';

export class PositionsBase extends IonicBase {

    constructor(public navCtrl: NavController, public navParams: NavParams, public apiSvc: RestAPIService) {
        super()
        this.parent = this.navParams.get("parent");
        this.pages = siteMap;
        this.getPositions();
        
    }
    
    public PositionsState = siteMap['Positions'];

    public pages : any;

    

    public PositionState = siteMap['Position'];
    public parent : any;
    public positions: any = []; 

    

    pop2() { 
        this.navCtrl.pop()
            .then(data => {
                this.navCtrl.pop();
            });
    }

    getPositions() {
        return new Promise(resolve => {
            
            this.apiSvc.getPositions()
                .then(result => { 
                    this.positions = result;
                    resolve(result);
                });
        });
    }

    reload() { return this.getPositions(); }

    addNewPosition() { // 
        var newPosition = {
            "Name" : "New Position " + (this.positions ? this.positions.length + 1 : 1),
            "Description" : ""
        }
        
        this.apiSvc.addNewPosition(newPosition)
            .then(data => {
                
                this.getPositions();
                this.goToState(this.PositionState, data, true);
            });
            
    }
    

    

    
    goToRootState(state, position = {}, editMode = false) : Promise<any> {
        return this.goToState(state, position, editMode, true);
    }

    goToState(state, position = {}, editMode = false, setRoot = false)  : Promise<any> {
        if (setRoot) {
            return this.navCtrl.setRoot(state.component, { position : position, parent: this, editMode: editMode });
        } else {
            return this.navCtrl.push(state.component, { position : position, parent: this, editMode: editMode });
        }
    }

    goToUrl(url) {
        console.log('SIMULATING OPEN OF URL: ' + url);
    }

    
}

