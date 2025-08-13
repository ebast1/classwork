// Calls to an external API are done asynchronously
//
// The Call to the API is sent server and WE NEED TO WAIT FOR THE RESPONSE
//     (unlike calls to function in the same component)
// 
// await is used to force the call to the external to be completed before processing continues
//
// When the call to the external API is made a Promise object is issued which will suspend
//          processing until we return from the API
//
// A Promise object is managed by "system"

import { CommonModule }      from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { RouterLink }        from '@angular/router';
import { Router }            from '@angular/router';
import { MatTooltipModule }  from '@angular/material/tooltip';
import { MoviesService }     from '../../services/movies.service-api'; // access the MoviesServices service
import { MoviesInfo }        from '../../interfaces/moviesInfo';

@Component({
  selector: 'app-movie-list',
  standalone: true,
  imports: [CommonModule, RouterLink, MatTooltipModule],
  templateUrl: './movie-list.component.html',
  styleUrl:    './movie-list.component.css'
})
// implements OnInit() indicate you want to add this to the OnInit() hook
//
// a hook is a place in the processing of a framework you want to add some additional processing
// Here we are telling Angular we are add some processing to its component initialization
export class MovieListComponent implements OnInit {  

// This will hold the data for the movies to be displayed
// the data will come from a call to a service
// it starts out as an empty array  
// Use use any as a data-type of data coming from an external source
// It allow any data type or format to be handle by the code
//     var-name   : data-type
public moviesList : any[] = []; // This is an array of MoviesInfo objects

// empty constructor to just have the service dependency injected into the component
// It could have process, but in this example there is other data to initialize except the moviesList                      
// The service and router are dependency injected into this constructor
constructor(private movieService  : MoviesService
           ,private router        : Router  ) {}

// instead of having the constructor call the service to get the data
// we are using ngOnInit which is processing done by Angular before it runs the constructor
// This is usually where any process performing external API calls are used
// You want to get the data from the external API before angular tries to do anything with it

// the async attribute tells Angular it may be causing asynchronous calls
// We are adding the initialization of our data array to Angular's component initialization
//    so it is available for the HTML page
async ngOnInit() {
 
  await this.fetchDataFromApi()
  
} 

async fetchDataFromApi() {
  // We have wait for the asynchronous process of retrieving the data before we gone
  // getMoviesList() in the movieServices async calls an external API
  const theData  = await this.movieService.getMoviesList(); // Initialize our moviesList from service
  // once the data comes back from the service, we can assign it to our array
  this.moviesList = theData

  //console.table(this.movieService) // optional - for testing and debugging only
  
}
 
  async updateMovie(aMovie : MoviesInfo) {
    await this.movieService.updateMovie(aMovie)
    this.fetchDataFromApi();
  }

  async deleteMovie(aMovie :MoviesInfo) {
    await this.movieService.deleteMovie(aMovie)
    this.fetchDataFromApi()
  }
 

}
