import React, {Component} from 'react';
import {Table} from 'react-bootstrap';
import {Button, ButtonToolbar} from 'react-bootstrap';
import { AddUserModal } from './AddUserModal';

export class User extends Component{
  
    constructor(props){
      super(props);
      this.state = {users:[], addModalShow:false}
      
    }
  
    refreshList(){
      fetch(process.env.REACT_APP_API)
      .then(response=>response.json())
      .then(data=>{
        this.setState({users:data});
      });
    }
  
    componentDidMount(){
      this.refreshList();
    }
  
    componentDidUpdate(){
      this.refreshList();
    }

    render(){
        const {users}=this.state;
        let addModalClose=()=>this.setState({addModalShow:false});
        return (
        <div>
            <Table className='mt-4' striped bordered hover size='sm'>
            <thead>
            <tr>
                <th>UserId</th>
                <th>DateRegistration</th>
                <th>DateLastOnline</th>
            </tr>
            </thead>
            <tbody>
            {users.map(user=>
                <tr key={user.UserId}>
                <td>{user.UserId}</td>
                <td>{user.DateRegistration}</td>
                <td>{user.DateLastOnline}</td>
                </tr>)}
            </tbody>
            </Table>

            <ButtonToolbar>
                <Button variant='primary'
                onClick={()=>this.setState({addModalShow:true})}>
                    Add User
                </Button>

                <AddUserModal show={this.state.addModalShow}
                onHide={addModalClose}></AddUserModal>
            </ButtonToolbar>

        </div>
        )
    }
}
