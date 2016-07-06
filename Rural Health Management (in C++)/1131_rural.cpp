#include<iostream>
#include<conio.h>
#include<string>
#include<vector>
using namespace std;

class Village
{
	public:
		int village_id,no_of_men,no_of_child,no_of_women,no_hospitals,hospitals_present;
		float avg_height,avg_weight;
		float bmi;
		
		int no_tube,avg_population,tube_present,no_toilets,toilets_already;
		float area;
		
		void getDetails()
		{
			cout<<"Enter Village ID > ";
			cin>>village_id;
			cout<<"Enter No of Men > ";
			cin>>no_of_men;
			cout<<"Enter No of Children > ";
			cin>>no_of_child;
			cout<<"Enter No of Women > ";
			cin>>no_of_women;
			cout<<"Enter Average Height(in m) > ";
			cin>>avg_height;
			cout<<"Enter Average Weight(in kg) > ";
			cin>>avg_weight;
			cout<<"Enter Village Area(in sq km) > ";
			cin>>area;
			cout<<"Enter Number of Hospitals already present > ";
			cin>>hospitals_present;
			cout<<"Enter Number of Tubewells already present >";
			cin>>tube_present;
			cout<<"Enter Number of Toilets already present >";
			cin>>toilets_already;
			
		}	   
		
		void displayDetails()
		{
			cout<<"Village ID > "<<village_id<<endl;
			cout<<"Number of Men > "<<no_of_men<<endl;
			cout<<"Number of Children > "<<no_of_child<<endl;
			cout<<"Number of Women > "<<no_of_women<<endl;
			cout<<"Average Height(in m) > "<<avg_height<<endl;
			cout<<"Average Weight(in kg) > "<<avg_weight<<endl;
			cout<<"Village Area(in sq km) > "<<area<<endl;
			cout<<"Number of Tubewells Present > "<<tube_present<<endl;
			cout<<"Number of Hospitals Present > "<<hospitals_present<<endl;
			cout<<"Number of Toilets present > "<<toilets_already;
			
		}
		
		
		
		
		void calculateHospitals()
		{
			
			bmi = avg_weight/(avg_height*avg_height);   //Calculating Body Mass Index
			cout<<"Average Body Mass Index is > "<<bmi<<endl<<endl;
			if(bmi <= 25 && bmi >22)
			{
				cout<<"Body Mass index of this village is good"<<endl;
				no_hospitals = area/3 - hospitals_present - 5;
				
			}
			else if(bmi <= 22 || bmi > 25)
			{
				cout<<"Body Mass index of this village is not good"<<endl;
				no_hospitals = area/3 - hospitals_present;
				
			}
			cout<<"Total No of Hospitals should be "<<(int)area/3<<endl;
			if(no_hospitals>0)  
	        	cout<<"So,No of Hospitals required in "<<area<<"sq km is "<<no_hospitals<<endl;
	        else
	        	cout<<"So,No need of new Hospital."<<endl;
			
			
			
		}
//////////////////////////////////////////////////////////////////////////////////////////////
        void calculateTube()
        {
        	
        	no_tube = (area * 4) - tube_present;
        	cout<<"Total No of tubewells should be "<<area*4<<endl;
			if(no_tube>0)  
	        	cout<<"So, No of tubewells required in "<<area<<"sq km is "<<no_tube<<endl;
	        else
	        	cout<<"So, No need of new tubewells."<<endl;
	    }
///////////////////////////////////////////////////////////////////////////////////////////
		
	    void calculateToilets()
	    {
	    	int population = no_of_men + no_of_women + no_of_child;
	    	no_toilets = population/4 - toilets_already;
	    	cout<<"Total no of toilets in this vilage should be "<<(int)population/4<<endl;
	    	if(no_toilets>0)  
	        	cout<<"So, No of toilets required in this village is "<<no_toilets<<endl;
	        else
	        	cout<<"So, No need of new toilets."<<endl;
	    	
	    }
////////////////////////////////////////////////////////////////////////////////////////
	    
}vill[100];





int main()
{
	int n,yesno;
    int choice;
    int mp,search;
    
    
  	do{
  	
		system("cls");
		cout<<"\t================================================================="<<endl;
		cout<<"\t=        Welcome to Rural Health Management Project             ="<<endl;
		cout<<"\t================================================================="<<endl;
		cout<<"\nWHAT DO YOU WANT TO DO?(Enter 1 or 2)"<<endl;
		cout<<"\n1.Give Village Details ";
		cout<<"\n2.Search Data of Village by ID"<<endl;
		int num;
		cin>>num;
		if(num==1)
		{
		    cout<<"Enter number of villages > ";
			cin>>n;
			
			system("cls");
		for(int i=0;i<n;i++)
		{
			cout<<"\t================================================================="<<endl;
			cout<<"\t=        	Welcome to Village "<<i+1<<" Portal              ="<<endl;
			cout<<"\t================================================================="<<endl;
			cout<<"\tEnter village "<<i+1<<" Details:"<<endl;
			vill[i].getDetails();
			system("cls");
			do
			{	
				cout<<"\t Please Choose your Problem\n";
				cout<<"\t1.Hospital Related Problem \n\t2.Tubewell Related Problem\n\t3.Sanitation Problem\n";
				cin>>choice;
				system("cls");
				switch(choice)
				{
					case 1:  vill[i].calculateHospitals();
							break;
							
				    case 2:  vill[i].calculateTube();
				    		break;
				    		
				    case 3:  vill[i].calculateToilets();
				    		break;
				    		
				    default: cout<<"Invalid Input! Try Again.. "<<endl;
				    		
				}	
				cout<<"\n\nWant to go to menu page?(1 for yes,0 for no):"<<endl;
				cin>>yesno;			
			} while(yesno==1);
			
		}
	}
		else if(num==2)
		{
			cout<<"Enter Village ID to fetch data :"<<endl;
			cin>>search;
			for(int i=0;i<n;i++)
			
			{
				if(search==vill[i].village_id)
				vill[i].displayDetails();
			}
		}
		else
		{
			cout<<"Invalid Input.. try Again..";
		}
		    cout<<"\n\nWant to go to main page?(1 for yes,0 for no):"<<endl;
			cin>>mp;
		}while(mp==1);
		
		cout<<"\n\n\n";
		cout<<"\t================================"<<endl;
		cout<<"\t=        Thank You             ="<<endl;
		cout<<"\t================================"<<endl;
		
	
	
	getch();
}
